%%    Data Input
%--------------------------------Electrical  Network--------------------
 numE =57; numG = 20; numH = 32;

 [lineE57,busE57,nodeG20,pipeG20,nodeH32,pipeH32] = E57G20H32data;

Y = ybusppg;          % Calling ybusppg.m to get Y-Bus Matrix..
busd = busE57;      % Calling busdatas..
BMva = 100;                 % Base MVA..
bus = busd(:,1);            % Bus Number..
type = busd(:,2);           % Type of Bus 1-Slack, 2-PV, 3-PQ..
V = busd(:,3);              % Specified Voltage..
del = busd(:,4);            % Voltage Angle..
Pg = busd(:,5)/BMva;        % PGi..
Qg = busd(:,6)/BMva;        % QGi..
Pl = busd(:,7)/BMva;        % PLi..
Ql = busd(:,8)/BMva;        % QLi..
Qmin = busd(:,9)/BMva;      % Minimum Reactive Power Limit..
Qmax = busd(:,10)/BMva;     % Maximum Reactive Power Limit..
P = Pg - Pl;                % Pi = PGi - PLi..
Q = Qg - Ql;                % Qi = QGi - QLi..
Psp = P;                    % P Specified..
Qsp = Q;                    % Q Specified..
G = real(Y);                % Conductance matrix..
B = imag(Y);                % Susceptance matrix..

pv = find(type == 2 | type == 1);            % PV Buses.. 
pq = find(type == 3);               % PQ Buses..  
npv = length(pv);                   % No. of PV buses..
npq = length(pq);                   % No. of PQ buses..

%----------------------Natural Gas Network------------------
nodeg = nodeG20;
pipeg = pipeG20;
GN = length(nodeg(:,1)); %%the Number of gas network
GP = length(pipeg(:,1));
pr = nodeg(:,2);                        
Lsp =nodeg(:,3);

gfrom = pipeg(:,2);
gto = pipeg(:,3);
com = pipeg(:,4);
Lg =  pipeg(:,5);
Dgas = pipeg(:,6);
C = pipeg(:,8);  %�ܵ�ϵ���� kcf/psia.h   %��
f = pipeg(:,7);


zg =0.8;
Tg = 281.15;
sg = 0.6048;    %0.6106   
kvg = 0.288e-6;
roughg = 0.05;
H9 = 1.20; H18 = 1.50;
pai = zeros(GN,1);

%----------------------Heat Network------------------
nodeh = nodeH32;
pipeh = pipeH32;
HN = length(nodeh(:,1)); %%the Number of heat network
HP = length(pipeh(:,1)); %%the Number of heat network
Ta = 10;                                 %�����¶�
node = nodeh(:,1);            % node Number..
Ts = nodeh(:,2)-Ta;              % supply temp
Tr = nodeh(:,3)-Ta;              % return temp
To = nodeh(:,3)-Ta;        % outlet temp ���ɻ�ˮ�¶ȵı���ֵ���������������(50-10)/100
       
HeatPower_CHP = nodeh(:,4);
HeatPower_B = nodeh(:,5);
Hl = nodeh(:,6);       
Ts_CHP =nodeh(:,7)-Ta;
Ts_B =nodeh(:,8)-Ta;

Cp = 4.182*1e-3;             % specific heat of water (MJ/kg.K �ȼ���MJ/kg.���϶�)
Cp1= 4182 ;                   %����thermal��
pipe = pipeh(:,1);
hfrom = pipeh(:,2);
hto = pipeh(:,3);
m = pipeh(:,4);
L = pipeh(:,5);
D = pipeh(:,6)*1e-3;   
lan = pipeh(:,7);
rough = pipeh(:,8)*1e-3;  %m

rou = 958.4;
g = 9.8;
kv = 0.294*1e-6;    %ˮ��kinematic viscosity  

% ----------------------Coupling------------------
alpha = 150;
belta = 4;
gamma = 0.01;
eCHP = 1.266;
eHP = 0.8;
% eCHP = 1/0.48;
% eHP = 0.65;
Hp = 100;
gCHP = 0.895;
eB = 0.95;
gB =0.8;
gP =0.8;
eGC = 0.8;
pi0 = 1.01325;
T0 = 273.15;
lg = 1.309;
TGC = 281.15;
H3 = 1.25;
ag =0;
bg=0.0025;
cg =0;
GCV = 40.14; 

Tol = 1e-3;  
Iter = 1;
%%    Iteration Starting
for Iter = 1:200
%%    Electrical Network
    P = zeros(numE,1);
    Q = zeros(numE,1);
    % Calculate P and Q    �ڵ㹦�ʷ���
    for i = 1:numE
        for k = 1:numE
             P(i) = P(i) + V(i)*V(k)*(real(Y(i,k))*cos(del(i)-del(k))+imag(Y(i,k))*sin(del(i)-del(k)));
             Q(i) = Q(i) + V(i)*V(k)*(real(Y(i,k))*sin(del(i)-del(k))-imag(Y(i,k))*cos(del(i)-del(k)));
%             P(i) = P(i) + V(i)* V(k)*(G(i,k)*cos(del(i)-del(k)) + B(i,k)*sin(del(i)-del(k)));
%             Q(i) = Q(i) + V(i)* V(k)*(G(i,k)*sin(del(i)-del(k)) - B(i,k)*cos(del(i)-del(k)));
            
        end
    end
    
    % Calculate change from specified value
    dPa = Psp-P;
    dQa = Qsp-Q;
    k = 1;
    dQ = zeros(npq,1); %���ɽڵ㣺�й��޹���֪��������ƫ��
    for i = 1:numE
        if type(i) == 3
            dQ(k,1) = dQa(i);
            k = k+1;
        end
    end
          % Mismatch Vector  ��ƽ��ڵ��⣬pv�ڵ�͸��ɽڵ����֪�й����ʣ�����ƫ��
    
    % Jacobian
        % J1 - Derivative of Real Power Injections with Angles..
    J1 = zeros(numE-1,numE-1);
   for i = 1:(numE-1)
        me = i+1;
        for k = 1:(numE-1)
            n = k+1;
            if n == me
                for n = 1:numE
                    J1(i,k) = J1(i,k) + V(me)* V(n)*(-G(me,n)*sin(del(me)-del(n)) + B(me,n)*cos(del(me)-del(n)));  % -Qi���ʽ
                end
                J1(i,k) = J1(i,k) - V(me)^2*B(me,me);  % -Qi-U^2*B
            else
                J1(i,k) =  V(me)* V(n)*(G(me,n)*sin(del(me)-del(n)) - B(me,n)*cos(del(me)-del(n)));
            end
        end
   end
    
        % J2 - Derivative of Real Power Injections with V..
    J2 = zeros(numE-1,npq);
    for i = 1:(numE-1)
        me = i+1;
        for k = 1:npq
            n = pq(k);
            if n == me
                for n = 1:numE
                    J2(i,k) = J2(i,k) + V(me)*V(n)*(G(me,n)*cos(del(me)-del(n)) + B(me,n)*sin(del(me)-del(n)));
                end
                J2(i,k) = J2(i,k) + V(me)^2*G(me,me);
            else
                J2(i,k) = V(me)*V(n)*(G(me,n)*cos(del(me)-del(n)) + B(me,n)*sin(del(me)-del(n)));
            end
        end
    end
    
        % J3 - Derivative of Reactive Power Injections with Angles..
    J3 = zeros(npq,numE-1);
    for i = 1:npq
        me = pq(i);
        for k = 1:(numE-1)
            n = k+1;
            if n == me
                for n = 1:numE
                    J3(i,k) = J3(i,k) + V(me)* V(n)*(G(me,n)*cos(del(me)-del(n)) + B(me,n)*sin(del(me)-del(n)));
                end
                J3(i,k) = J3(i,k) - V(me)^2*G(me,me);
            else
                J3(i,k) = V(me)* V(n)*(-G(me,n)*cos(del(me)-del(n)) - B(me,n)*sin(del(me)-del(n)));
            end
        end
    end
    
        % J4 - Derivative of Reactive Power Injections with V..
    J4 = zeros(npq,npq);
    for i = 1:npq
        me = pq(i);
        for k = 1:npq
            n = pq(k);
            if n == me
                for n = 1:numE
                    J4(i,k) = J4(i,k) + V(me)*V(n)*(G(me,n)*sin(del(me)-del(n)) - B(me,n)*cos(del(me)-del(n)));
                end
                J4(i,k) = J4(i,k) - V(me)^2*B(me,me);
            else
                J4(i,k) = V(me)* V(n)*(G(me,n)*sin(del(me)-del(n)) - B(me,n)*cos(del(me)-del(n)));
            end
        end
    end
    
    Jee = - [J1 J2; J3 J4];     % Jacobian Matrix..
%%    District Heating Network  

 Ah = zeros (HN,HP);
 for I = 1:HP
     if m(I)>0
           Ah(hfrom(I),I) = -1;
           Ah(hto(I),I) = 1;
        else
           Ah(hfrom(I),I) = 1;
           Ah(hto(I),I) = -1;
     end
 end
Am = Ah*m; %%%���ڵ� ���� ��������


%------------------------------------- ������CHP��EB�ṩ�ȹ��ʣ���ˮ�¶ȼ������� ----------------------------------- 

mCHP = zeros(HN,1); mB = zeros(HN,1);
for i =1: HN
    mCHP(i) = HeatPower_CHP(i)/(Ts_CHP(i)-Tr(i))/Cp;  %%
    mB(i) = HeatPower_B(i)/(Ts_B(i)-Tr(i))/Cp;        %% 
end

dfai = zeros(HN,1); 

for I=1:HN
    if Hl(I) > 0                    %�ڵ㴦�и���
        dfai(I,1) =  Cp*(Am(I)+mCHP(I)+mB(I))*(Ts(I)-To(I))-Hl(I);   
    elseif Hl(I) == 0               %�ڵ㴦�޸���
        dfai(I,1) =  Cp*(Am(I)+mCHP(I)+mB(I))*(Ts(I)-Tr(I))-Hl(I);    %%  
    end
end
dfai(1,:) = []; %ɾ����һ��

%%-------------------------------------Bh = 0
for I = 1:HP   %���µ�1-10�ڵ����Re
Re(I) = 4*m( I )/kv/rou/pi/D(I);   
end
Re = abs(Re);

for I = 1:HP
K(I) = rough(I)/D(I);
% K(I) = rough(I)/(D(I)/1000);
end

Ff=zeros(1,HP);   %��friction factor
for I = 1:HP
    if Re(I)<2300
        Ff(I) = 64/Re(I);
    elseif Re(I)>4000
X1(I) = K(I) * Re(I) * 0.123968186335417556;    
X2(I) = log(Re(I)) - 0.779397488455682028; 

Ff(I) = X2(I) - 0.2 ; 
E(I) = ( log (X1(I)+Ff(I)) + Ff(I) - X2(I) ) / ( 1 + X1(I) + Ff(I) ) ;
Ff(I) = Ff(I) - (1+X1(I)+Ff(I)+0.5*E(I)) * E(I) * (X1(I)+Ff(I)) / (1+X1(I)+Ff(I)+E(I) *(1+E(I) / 3 ) ) ;

E (I)= ( log (X1(I)+Ff(I)) + Ff(I) - X2(I) )/ ( 1 + X1(I) + Ff(I) ) ;
Ff(I) = Ff(I) - (1+X1(I)+Ff(I)+0.5*E(I)) * E(I) * (X1(I)+Ff(I)) / (1+X1(I)+Ff(I)+E(I)*(1+E(I) / 3 ) ) ;

Ff(I) = 1.151292546497022842 / Ff(I) ;
Ff(I) = Ff(I) * Ff(I); 

    elseif Re(I)>2300 && Re(I)<4000
            x0=2300;y0=64/2300;
            x1=4000;y1=0.0491;
            Ff(I)=y0+((Re(I)-x0)*(y1-y0))/(x1-x0);
     end
end


Kh = zeros(HP,1);
for I=1:HP
    Kh(I) = 8*L(I)*Ff(I)/((D(I))^5)/rou^2/pi^2/g;  
end
%------------------------��· B����
% Nloop = [1   2   3   4   5   6   7   8   9   10  ];   %�Ի�״��ˮ������
% Ploop = [10  12  13  18  21  24  27  30  31  6  ];
Bh = zeros(HP,1);
for I = 1:HP
    if (I == 10) || (I ==12) || (I==13) || (I==18) || (I ==21) || (I==31) || (I==6)
        if m(I)>0
            Bh(I) = 1;
        elseif m(I)<0
            Bh(I) = -1;
        end
    elseif (I == 24) || (I==27) || (I==30)
        if m(I)>0
            Bh(I) = -1;
        elseif m(I)<0
            Bh(I) = 1;
        end
    end
end

% BK = zeros(HP,1);
% for I = 1:HP
%     BK (I) = Bh(I)*Kh(I);
% end

dh=0;
for I =1:HP
dh = dh + Bh(I)*Kh(I)*abs(m(I))*m(I);  % B*(K .*abs(m)*m)
end

 %% ------------------------------------- supply temperature ----------------------------------- 
FA = zeros(HP,1);
for I=1:HP     %����ܵ����� 
    FA(I)=exp(-lan(I)*L(I)/Cp1/m(I)); %%% Cp1=4182J/kg k ;L(m)
end

Cs = zeros(HN,HN); bs = zeros(HN,1);

J1 = hfrom;    % node j
I1 = hto;      % node i 
p1 = pipe;     %�����ܵ� 

for I = 1:HP       %��m����仯ʱ��ȷ��i��j
    if m(I)<0;
        J1(I) = hto(I);
        I1(I) = hfrom(I);
    end
end
% find supply network mixing nodes 
mixnode=[];numbermix=1;     
for I = 1:HN
    flag = 0;
    Ah_row = Ah(I,:);   %Ah HN*HP
    for j = 1:HP      
        if(Ah_row(j)==1)  %�ڵ�-֧·���������У�1Ϊ����
            flag = flag+1;
        end
    end
    if((flag>=2) || (flag>=1 && ((mCHP(I)>0)||(mB(I)>0))) )   % flag>=0 && ((mCHP(I)>0)||(mB(I)>0)) ��ʱ CHP��B ��Ϊ�õ�Դ���õ��޸��ɣ������¶���֪�����󲻰����õ�
        mixnode(numbermix)= I; %���ҵ��Ļ�Ͻڵ� ����mixnode��
        numbermix=numbermix+1;
    end
end
Number_mixs = length(mixnode);  

%Cii Cij_mix
for I = 1:HN
    for J = 1:Number_mixs
        if I == mixnode(J)
            for k = 1:HP
                if hto(k) == I;
                   Cs(I,I) = m(k)+Cs(I,I);
                   Cs(I,J1(k)) = -m(k)*FA(k);   %�˴�Ӧȥ�����������ɽڵ��Դ�ڵ㣬�ں��潫Cs��row1 line1ȥ��
                end
            end
            Cs(I,I) = Cs(I,I)+ mCHP(I)+mB(I); %��ϵ㴦����ע��õ�Ĺܵ�����֮�� + ע��õ��Դ������
        end
    end
  
end
%Cii Cij_nonmix
for I = 1:HN
    for J = 1:Number_mixs
        if (I ~= mixnode(J)) && (Cs(I,I)==0)
           for k = 1:HP
                if hto(k) == I;
                   Cs(I,I) = 1;
                   Cs(I,J1(k)) = -FA(k);   %�˴�Ӧȥ�����������ɽڵ��Դ�ڵ㣬�ں��潫Cs��row1 line1ȥ��������
                end
            end
        end   
    end  
end
%bs_mix
for I = 1:HN
    for J = 1:Number_mixs
        if I == mixnode(J)  %��Ͻڵ�
            for k = 1:HP
                if( hto(k) == I ) &&  (J1(k)==1||J1(k)==32);  %��Ͻڵ㣬��һ���ܵ����ӽڵ�1��ƽ��ڵ㣩��ùܵ�����һ��ΪԴ
                  bs(I,1) = m(k)*Ts(J1(k))*FA(k)+bs(I,1);
                end
            end
             if (mCHP(I)>0) || (mB(I)>0)   %��Ͻڵ㣬�Ҹõ㴦����CHP��Boiler 
                bs(I,1) = bs(I,1) + mCHP(I)*Ts_CHP(I)+mB(I)*Ts_B(I);  
             end
        end
    end
end 
%bs_nonmix
for I = 1:HN
    for J = 1:Number_mixs
        if (I ~= mixnode(J)) &&(bs(I,1) == 0)  
            for k = 1:HP
                   if ( hto(k) == I)  &&(J1(k)==1||J1(k)==31)% ƽ��ڵ�1��ĳ�ڵ�ֻ��CHPB��ע�룬Ts1 ���������������bs���漰��Ts1ʱ �����ֳ�����������Ts������Cs��
                  bs(I,1) = Ts(J1(k))*FA(k);
                   end
            end 
        end
    end
end 

Cs = Cs(2:HN-2,2:HN-2); %ȥ��ƽ��ڵ��ĩβ����Դ�ڵ㣬��Ϊ�õ��¶���֪�����������   
bs = bs(2:HN-2,1); 

 % supply temperature  mismatch -----------------
 dTs =Cs*Ts(2:HN-2)-bs; 

%% ------------------------------------- return temperature ----------------------------------- 
Cr = zeros(HN,HN) ;br = zeros(HN,1); 

% find return network mixing nodes 
rmixnode=[];rnumbermix=1;     
for I = 1:HN
    flag = 0;
    rAh = -1.*Ah(I,:);   %Ah HN*HP   _row
    for j = 1:HP      
        if(rAh(j)==1)  %�ڵ�-֧·���������У�1Ϊ����
            flag = flag+1;
        end
    end
    if((flag>=2) || (flag>=1 && (Hl(I)>0))) 
        rmixnode(rnumbermix)= I; %���ҵ��Ļ�Ͻڵ� ����mixnode��
        rnumbermix=rnumbermix+1;
    end
end
rNumber_mixs = length(rmixnode);  

%% ��ˮ����ϵ���������
%��ˮ�����ϵ� �и��� (1/ ��CHP ��B  eg.14�ڵ������е�4,9,10,13  2/��CHP B
%%eg.14�ڵ������еĽڵ�4ȥ��chp��b�����)
for I = 1:HN
  for J= 1:rNumber_mixs
      if (I == rmixnode(J)) 
        br(I,1) = (Am(I)+mCHP(I)+mB(I))*To(I);
            for k = 1:HP      
                if hfrom(k) ==I
                   Cr(I,I) = m(k) + Cr(I,I);
                   Cr(I,I1(k)) = -m(k)*FA(k);   %�˴�Ӧȥ�����������ɽڵ��Դ�ڵ㣬�ں��潫Cs��row1 line1ȥ��
                end
            end
           Cr(I,I) = Am(I)+Cr(I,I)+mCHP(I)+mB(I);
      end
  end
end
   
%��ˮ�����ϵ� �޸��� ��CHP B   eg.14�ڵ������еĽڵ�11
for I = 1:HN
  for J= 1:rNumber_mixs
      if (I == rmixnode(J)) &&(mCHP(I)==0 && mB(I)==0) && (Hl(I)==0) &&(Cr(I,I)==0)
        br(I,1) = 0;
            for k = 1:HP
%                 if hto(k) == I;
%                    Cr(I,I) = m(k)+Cr(I,I) ;
                if hfrom(k) ==I
                   Cr(I,I) = m(k)+Cr(I,I) ;
                   Cr(I,I1(k)) = -m(k)*FA(k);   %�˴�Ӧȥ�����������ɽڵ��Դ�ڵ㣬�ں��潫Cs��row1 line1ȥ��
                end
            end
      end
  end
end
        
        
% ��ĩ�˸���  ���ǻ�ϵ�
for I = 1:HN
  for J= 1:rNumber_mixs
      if (I ~= rmixnode(J))&&(Cr(I,I)==0)
        br(I,1) = To(I);
        Cr(I,I) = 1 ;
      end
  end
end

 
Cr = Cr(2:HN,2:HN); br = br(2:HN,1);
% return temperature  mismatch -------------------------
dTr = Cr*Tr(2:HN)-br;
Tr(1) = Tr(2)*FA(1);          %( m(1)*Tr(2)*FA(1) + m(9)*Tr(9)*FA(9))/(m(1)+m(9)); %ƽ��ڵ㷵���¶�
Tr(31) =( m(30)*Tr(28)*FA(30) + m(31)*To(7)*FA(31))/(m(30)+m(31)); 
Tr(32) = To(11)*FA(32);

dH = [dfai;dh;dTs;dTr]; 

J12 = zeros(HP,HN-3);   %   3
J13 = zeros(HP,HN-1); 
J21 = zeros(HN-3,HP);   %   3
J23 = zeros(HN-3,HN-1);    %   3
J31 = zeros(HN-1,HP);   
J32 = zeros(HN-1,HN-3); %   3
%J11
Jm = zeros(HN,HP);
Jh = zeros(1,HP);
for I =1:HN    
    for J=1:HP                       %Ah�ڵ�-�ܵ��������󣬰���Դ��
Jm(I,J) = Cp*Ah(I,J)*(Ts(I)-Tr(I));  %Cp*A*detaT  û��Cp����������������������
    end
end
Jm(1,:) = [];     %��Դ�����ڵĽڵ�-�ܵ�����������ɾ��.

for I =1:HP
   Jh(1,I) = 2*Bh(I)*Kh(I)*abs(m(I));
end
%Jh = 2*BK'*abs(m);

J11 = [Jm;Jh;];   %2Bkm
%J12
for I=2:HN-2  %��%3
        J12(I-1,I-1) =  Cp*(Am(I)+mCHP(I)+mB(I));  
end
%J13  
for I=2:HN
    if Hl(I) == 0
        J13(I-1,I-1) = - Cp*(Am(I)+mCHP(I)+mB(I)); 
    end
end

J22 = Cs;
J33 = Cr;

Jhh = [J11 J12 J13; J21 J22 J23; J31 J32 J33];

%%    Natural Gas Network  

    for I =1:GN
    pai(I) = pr(I)*pr(I);
    end
Ag = zeros(GN,GP);     %��������
sign = zeros(GP,1);   %���ź���

for I = 1:GP                %%�ܵ�����ѭ��
    if com(I)^2*pai(gfrom(I)) > pai(gto(I)) 
      Ag(gfrom(I),I) = -1;  
      Ag(gto(I),I) = 1; 
      sign(I) = 1;     %���ź���
    else
      Ag(gfrom(I),I) = 1;
      Ag(gto(I),I) = -1;
      sign(I) = -1;
    end
end


for I = 1:GP
  
    f(I) = C(I)* sign(I)*sqrt(sign(I)*(com(I)^2*pai(gfrom(I))-pai(gto(I))));   
      
end

     % Natural Gas Jacobian
    A1 = Ag(2:GN,:);      %������֧·���ڵ�������� 
    % ��ܵ�����ѹ����
      Agt =(Ag)'; %
    dpai = zeros(GP,1);
    pai1 = zeros(GN,1);
    for I = 1:GP
        if com(I) ==1
        dpai(I) = -Agt(I,:)*(pai);%%
        elseif com(I) ==1.2 && I ==12 
        pai1 = pai;
        pai1(9) = H9^2*pai(9);%% �ģ�������
        dpai(I) = -Agt(I,:)*(pai1);
        elseif com(I) ==1.2 && I ==13 
        pai1 = pai;
        pai1(9) = H9^2*pai(9);%% �ģ�������
        dpai(I) = -Agt(I,:)*(pai1);
        elseif com(I) ==1.5 && I ==23
        pai1 = pai;
        pai1(18) = H18^2*pai(18);%% �ģ�������
        dpai(I) = -Agt(I,:)*(pai1);
        end
    end
   
    DIAG =zeros(GP,1);  
    for I =1:GP
    DIAG(I)=f(I)/2/dpai(I);  %0.5*f/ѹ����
    end
    
    Dg = diag(DIAG);
    Jgg = -A1*Dg*(A1)';          % Natural Gas Jacobian Matrix
%%    Modify Mismatch
%������������ E
CHP_P = zeros(numE,1); Pump_P = zeros(numE,1); EB_P = zeros(numE,1); COM_P = zeros(numE,1);P2G_P = zeros(numE,1);

fai(1) = Cp*abs(Am(1))*(Ts(1)-Tr(1));
HeatPower_B(1) = fai(1); 
Ecom9 = (151.456/eGC)*(pi0/T0)*(lg/(lg-1))*zg*TGC*f(10)*(H9^(lg/(lg-1))-1); 
Ecom9 = (151.456/eGC)*(pi0/T0)*(lg/(lg-1))*zg*TGC*f(11)*(H9^(lg/(lg-1))-1)+Ecom9;
Ecom18 = (151.456/eGC)*(pi0/T0)*(lg/(lg-1))*zg*TGC*f(22)*(H18^(lg/(lg-1))-1); 

CHP_P(3) = HeatPower_CHP(31)/eCHP;                                      
EB_P(29) = abs(fai(1))/eB;               
COM_P(7) = 745.7*(10^(-6))*Ecom9/3600;  COM_P(48) = 745.7*(10^(-6))*Ecom18/3600; 

P2G_P (44) = 30; 
P2G_P (52) = 30;  

for I = 1:numE
    dPa(I) = Psp(I)-P(I)+CHP_P(I)/BMva-EB_P(I)/BMva - COM_P(I)/BMva - P2G_P (I)/BMva ;
end
dP = dPa(2:numE); 
dE = [dP; dQ];

%����������������������������������������G
fCHP = zeros(GN,1) ; fB = zeros(GN,1) ; fG = zeros(GN,1) ;fCOM = zeros(GN,1) ;fP2G = zeros(GN,1);

fCHP(3) = 3.412*Cp*mCHP(31)*(Ts_CHP(31)-Tr(31))*(1/eCHP+1)/gCHP/GCV ;  %  
fB(3) =  3.412*Cp*mB(32)*(Ts_B(32)-Tr(32))/gB/GCV;    %����ƽ��ڵ㴦��ȼ����¯ ���ĵ���Ȼ������|||||||����ֵ
fG(16) = (alpha+belta*Pg(8)*BMva+gamma*(Pg(8)*BMva)^2)/GCV; %����ƽ��ڵ㴦��ȼ���ֻ� 8 6
fG(6) = (alpha+belta*Pg(12)*BMva+gamma*(Pg(12)*BMva)^2)/GCV;   %12  5
fG(3) = (alpha+belta*P(1)*BMva+gamma*(P(1)*BMva)^2)/GCV;  

eP2G = 0.7;
LHV = 37.4;
fP2G(5) = (3600*eP2G/LHV) * (P2G_P(44)/BMva) / 10^6; %10^6��λ���㣬
fP2G(12) = (3600*eP2G/LHV) * (P2G_P(52)/BMva) / 10^6;

dG=zeros(GN,1);   
    for I =1:GN
    dG(I,1) = Ag(I,:)*f - Lsp(I)-fCHP(I)-fB(I)-fG(I)-fCOM(I)+fP2G(I) ;  %%�ڵ�����ƫ��
    %dG(I,1) = Ag(I,:)*f - Lsp(I)+fCHP(I)+fB(I)+fG(I)+fCOM(I) ;
    end
    
  dG(1,:) = []; %ɾ��Դ�ڵ�������
    
    dMES =[ dE; dG; dH];
%%    Coupling Jacobin Matrix 
np_fix =1;  nf_fix = GN - np_fix;
Jeg =zeros(numE-1+npq,GN-1);
Jeh = zeros(numE-1+npq,HP+(HN-1)+HN-3); %3
Jge = zeros(GN-1,numE-1+npq);
Jgh = zeros(GN-1,HP+(HN-1)+HN-3); %3
Jhe = zeros(HP+(HN-1)+HN-3,numE-1+npq); %3
Jhg = zeros(HP+(HN-1)+HN-3,GN-1); %3
%Jeg�綯ѹ����
k_com = -745.7*(10^(-6))*(151.456/eGC)*(pi0/T0)*(lg/(lg-1))*zg*TGC/3600/BMva;
Jeg(5-1,9-np_fix) = k_com*(H9^(lg/(lg-1))-1) *(C(10)+C(11))*(1/2)*(-1)/sqrt(pai(8)-pai(9)); %2*pr(9)
Jeg(5-1,9-np_fix) = k_com*(H9^(lg/(lg-1))-1) *(C(10)+C(11))*(1/2)*(-1)/sqrt(pai(8)-pai(9)); %2*pr(9)
%Jeg(4-1,17-np_fix) = k_com*(H18^(lg/(lg-1))-1) *C(22)*(1/2)*(2*pr(17))/sqrt(pai(17)-pai(18));
Jeg(5-1,18-np_fix) = k_com*(H18^(lg/(lg-1))-1) *C(22)*(1/2)*(-1)/sqrt(pai(17)-pai(18)); %2*pr(18)

%Jeh���¯ 
Jgh(3-1,1) = - 3.412*Cp*(Ts(1)-Tr(1))/eB/GCV;

%Jgeȼ�������
%��Ǳ仯��������Ӱ��
Jge(3-np_fix,2-1) = -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV  * V(1)* V(2)*(G(1,2)*sin(del(1)-del(2)) - B(1,2)*cos(del(1)-del(2))); 
Jge(3-np_fix,15-1) = -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV  * V(1)* V(15)*(G(1,15)*sin(del(1)-del(15)) - B(1,15)*cos(del(1)-del(15))); 
Jge(3-np_fix,16-1) = -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV  * V(1)* V(16)*(G(1,16)*sin(del(1)-del(16)) - B(1,16)*cos(del(1)-del(16))); 
Jge(3-np_fix,17-1) = -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV  * V(1)* V(17)*(G(1,17)*sin(del(1)-del(17)) - B(1,17)*cos(del(1)-del(17))); 
%��ѹ�仯��������Ӱ�� %15-7 �ǽڵ�15��Ϊ���ɽڵ� 7��PV�ڵ�
Jge(3-np_fix,numE-1+15-7) =  -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV * V(1)*(real(Y(1,15))*cos(del(1)-del(15))+imag(Y(1,15))*sin(del(1)-del(15))); 
Jge(3-np_fix,numE-1+16-7) =  -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV * V(1)*(real(Y(1,16))*cos(del(1)-del(16))+imag(Y(1,16))*sin(del(1)-del(16))); 
Jge(3-np_fix,numE-1+17-7) =  -(belta*BMva+gamma*2*P(1)*BMva*BMva)/GCV * V(1)*(real(Y(1,5))*cos(del(1)-del(17))+imag(Y(1,17))*sin(del(1)-del(17))); 


J = [Jee Jeg Jeh; Jge Jgg Jgh; Jhe Jhg Jhh];

%%    Compute Corection Vector and Update it
Xe = Jee\dE;
Xh = Jhh\dH;
Xg = Jgg\dG;
    X = J\dMES;  
    dTh = X(1:numE-1);      
    dV = X(numE:numE-1+npq);       %UD*
    dpr = X(numE+npq:numE+npq+GN-2);
    dm = X(numE+npq+GN-1:numE+npq+GN-1+HP-1);      
    dts = X(numE+npq+GN-1+HP:numE+npq+GN-1+HP+HN-3-1); %�� 3
    dtr = X(numE+npq+GN-1+HP+HN-3:numE+npq+GN-1+HP+HN-3+HN-2);  %�� 3
  %����״̬���� 
   
    del(2:numE) = del(2:numE) - dTh;  
    
    k = 1;
    for i = 2:numE
        if type(i) == 3
            V(i) = V(i) - dV(k);        
            k = k+1;
        end
    end
    
    pai(2:GN) = pai(2:GN) - dpr;
    m(1:HP) = m(1:HP) - dm;
    Ts(2:HN-2) = Ts(2:HN-2) - dts;
    Tr(2:HN) = Tr(2:HN) - dtr;
    
    

%%    Convergence?
    
        if max(abs(dMES)) <Tol
    break
        end
        
        pr =sqrt(pai);
end

%% Data Show
% Y = ybusppg(numE);                % Calling Ybus program..
lined = lineE57;          % Get linedats..
busd = busE57;            % Get busdatas..
Vm = pol2rect(V,del);           % Converting polar to rectangular..
Del = 180/pi*del;               % Bus Voltage Angles in Degree...
fb = lined(:,1);                % From bus number...
tb = lined(:,2);                % To bus number...
nl = length(fb);                % No. of Branches..
Pg = busd(:,5);                 % PLi..
Qg = busd(:,6);                 % QLi..
Pl = busd(:,7);                 % PLi..
Ql = busd(:,8);                 % QLi..
 
nodeg = nodeG20;
pipeg = pipeG20;
GN = length(nodeg(:,1)); %%the Number of gas network
GP = length(pipeg(:,1));
Cp = 4.182*1e-3;
nodeh = nodeH32;
pipeh = pipeH32;
HN = length(nodeh(:,1)); %%the Number of heat network
HP = length(pipeh(:,1)); 
hfrom=pipeh(:,2);
hto=pipeh(:,3);
Hl = nodeh(:,6);  
L = pipeh(:,5);
lan = pipeh(:,7);
Ta = 10;

Z=zeros(numE,10);
Iij = zeros(numE,numE);
Sij = zeros(numE,numE);
Si = zeros(numE,1);

% Bus Current Injections..
 I = Y*Vm;
 Im = abs(I);
 Ia = angle(I);
 
%Line Current Flows..
for mt = 1:nl
    p = fb(mt); q = tb(mt);
    Iij(p,q) = -(Vm(p) - Vm(q))*Y(p,q); % Y(m,n) = -y(m,n)..
    Iij(q,p) = -Iij(p,q);
end
Iij = sparse(Iij);
Iijm = abs(Iij);
Iija = angle(Iij);

for I = 1:nl
     Z(I,1)=fb(I);
     Z(I,2)=tb(I);
     Z(I,3)= real(Vm(fb(I))*conj(Iij(fb(I),tb(I)))*BMva);
     Z(I,4)= imag(Vm(fb(I))*conj(Iij(fb(I),tb(I)))*BMva);
     Z(I,5)=tb(I);
     Z(I,6)=fb(I);
     Z(I,7)= real(Vm(tb(I))*conj(Iij(tb(I),fb(I)))*BMva);
     Z(I,8)= imag(Vm(tb(I))*conj(Iij(tb(I),fb(I)))*BMva);
end
Sij = sparse(Sij);
Pij = real(Sij);
Qij = imag(Sij);
 % Sij(mt,n) = Vm(mt)*conj(Iij(mt,n))*BMva;
% Line Losses..
Lij = zeros(nl,1);
for mt = 1:nl
    p = fb(mt); q = tb(mt);
    Lij(mt) =  Vm(p)*conj(Iij(p,q))*BMva +  Vm(q)*conj(Iij(q,p))*BMva;
    
end
Lpij = real(Lij);
Lqij = imag(Lij);

for mt=1:nl
   Z(mt,9)=Lpij(mt,1);
   Z(mt,10)=Lqij(mt,1);
end 
% Bus Power Injections..
for i = 1:numE
    for k = 1:numE
        Si(i) = Si(i) + conj(Vm(i))* Vm(k)*Y(i,k)*BMva;
    end
end
Pi = real(Si);
Qi = -imag(Si);
Pg(1) = Pi(1) + Pl(1) + CHP_P(1) + Pump_P(1) + COM_P(1) + EB_P(1);
Qg = Qi+Ql;
 
Heat_ij = zeros (HP,1);  Heat_ji = zeros (HP,1);  Heat_loss = zeros (HP,1);

% �����ܵ������ȹ���
FAji = zeros(HP,1);
for I=1:HP     %����ܵ����� 
    FAji(I)=exp(-lan(I)*L(I)/4182/(-m(I))); %%% Cp1=4182J/kg k ;L(m)
end
for I = 1:HP
Heat_ij(I) = Cp * m(I) * (Ts(hfrom(I)) - FA(I) * Tr(hto(I)) );
Heat_ji(I) = - Cp * m(I) * (Ts(hto(I)) - FAji(I) * Tr(hfrom(I)) );
Heat_loss(I) =  Heat_ij(I) + Heat_ji(I);
end
fai = zeros(HN,1);        
for I=1:numH
    fai(I,1) = Cp*(Am(I)+mCHP(I)+mB(I))*(Ts(I)-Tr(I));     %����ڵ�ע���ȹ���  ûʲô�� ���Դ�����֤����������
end

Ts = Ts + Ta;   
Tr = Tr + Ta;  

%��������ڵ�����
myf1 = fopen('EBusResult.txt','w');
% fprintf(myf,'| Bus_No |    V_pu   |  Angle_Degree  |     Injection      |     Generation     |          ELoad      |  CHP     |   COM_P | Pump_P | EB_P |\n');
fprintf(myf1,'Bus_No,V_pu,Angle_Degree,Injection_MW,Injection_MVar,Generation_MW,Generation_Mvar,ELoad_MW,ELoad_MVar,CHP_MW,COM_P_MW,Pump_P_MW,EB_P_MW\n');
for me = 1:numE
    fprintf(myf1,'%g', me); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', V(me));fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Del(me));fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Pi(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Qi(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Pg(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Qg(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Pl(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Ql(me));fprintf(myf1,',');
    fprintf(myf1,'%0.4f', CHP_P(me)); fprintf(myf1,',');
    fprintf(myf1,'%0.4f', COM_P(me));fprintf(myf1,',');
    fprintf(myf1,'%0.4f', Pump_P(me));fprintf(myf1,',');
    fprintf(myf1,'%0.4f', EB_P(me));
    fprintf(myf1,'\n');
end
fclose(myf1); 

%�������֧·����
myf2 = fopen('ELineResult.txt','w');
% fprintf(myf,'|From|To |    P    |    Q     | From| To |    P     |   Q     |      Line Loss      |\n');
fprintf(myf2,'FromBus_No,ToBus_No,P_MW,Q_MVar,Loss_MW,Loss_MVar\n');
for me = 1:nl
    p = Z(me,1); q = Z(me,2); Pij=Z(me,3); Qij=Z(me,4); Pji= Z(me,7); Qji=Z(me,8); Lpij= Z(me,9); Lqij=Z(me,10);
    fprintf(myf2,'%g', p); fprintf(myf2,',');
    fprintf(myf2,'%g', q); fprintf(myf2,',');
    fprintf(myf2,'%0.4f', Pij); fprintf(myf2,',');
    fprintf(myf2,'%0.4f', Qij); fprintf(myf2,',');
    fprintf(myf2,'%0.4f', Lpij); fprintf(myf2,',');
    fprintf(myf2,'%0.4f', Lqij);
    fprintf(myf2,'\n');
end
fclose(myf2); 

%��������ڵ�����
myf3 = fopen('GNodeResult.txt','w');
%fprintf(myf,'| Node | Pressure |  Node LOAD Flow| E-Generator| CHP   |  Gas-Boiler |\n');
fprintf(myf3,'Node_No,Pressure_bar,LoadFlow_MSCM/h,EGenerator_MSCM/h,CHP_MSCM/h,Gas-Boiler_MSCM/h\n');
for w = 1:GN
    fprintf(myf3,'%g', w); fprintf(myf3,',');
    fprintf(myf3,'%0.4f', pr(w)); fprintf(myf3,',');
    fprintf(myf3,'%0.4f', Lsp(w)); fprintf(myf3,','); 
    fprintf(myf3,'%0.4f', fG(w)); fprintf(myf3,',');
    fprintf(myf3,'%0.4f', fCHP(w));fprintf(myf3,',');
    fprintf(myf3,'%0.4f', fB(w));
    fprintf(myf3,'\n');

end
fclose(myf3); 

%�������֧·����
myf4 = fopen('GPipeResult.txt','w');
%  fprintf(myf,'                |From | To   |  Gas Flow  |\n');
 fprintf(myf4,'FromNode_No,ToNode_Node,GasFlow_SCM/h\n');
for w = 1:GP
    p = gfrom(w); q = gto(w); 
% fprintf(myf,'-------------------------------------------------------------------------------------\n');
 fprintf(myf4,'%g', p); fprintf(myf4,',');
 fprintf(myf4,'%g', q); fprintf(myf4,',');
 fprintf(myf4,'%0.4f', f(w));
 fprintf(myf4,'\n'); 
end

fclose(myf4); 

%��������ڵ�����
myf5 = fopen('HNodeResult.txt','w');
%    fprintf(myf,'| Node | Supply Temperature | Return Temperature | Heat load  |       CHP     |      Boiler    |\n');
    fprintf(myf5,'Node_No,SupplyTemperature_��C,ReturnTemperature_��C,Heatload_MW,CHP_MW,Boiler_MW\n');
    for w = 1:numH
    fprintf(myf5,'%g', w); fprintf(myf5,',');  
    fprintf(myf5,'%0.4f', Ts(w)); fprintf(myf5,',');
    fprintf(myf5,'%0.4f', Tr(w) );  fprintf(myf5,',');
    fprintf(myf5,'%0.4f', fai(w)); fprintf(myf5,',');
    fprintf(myf5,'%0.4f', Hl(w)); fprintf(myf5,',');
    fprintf(myf5,'%0.4f', HeatPower_CHP(w)); fprintf(myf5,',');
    fprintf(myf5,'%0.4f', HeatPower_B(w));
    fprintf(myf5,'\n');
    end
   
fclose(myf5); 

%��������ڵ�����
myf6 = fopen('HPipeResult.txt','w');
%    fprintf(myf,'                |From    | To   | Mass Flow |  Heat_ij|  Heat_ji|  Heat_loss|\n');
    fprintf(myf6,'FromNode_No,ToNode_No,MassFlow_Kg/s,Heat_MW,HeatLoss_MW\n');
    for w = 1:HP
        p = hfrom(w); q = hto(w); 
% fprintf(myf,'-------------------------------------------------------------------------------------\n');
    fprintf(myf6,'%g', p); fprintf(myf6,',');
    fprintf(myf6,'%g', q); fprintf(myf6,',');
    fprintf(myf6,'%0.4f', m(w));fprintf(myf6,',');
    fprintf(myf6,'%0.4f', Heat_ij(w)); fprintf(myf6,',');
    fprintf(myf6,'%0.4f', Heat_loss(w)); 
    fprintf(myf6,'\n');
    end 

fclose(myf6); 
quit;