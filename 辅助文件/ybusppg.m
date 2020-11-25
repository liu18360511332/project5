% Program to for Admittance And Impedance Bus Formation....
function Y = ybusppg  % Returns Y

%linedata = linedatas(numE);      % Calling Linedatas...
lineE57 = E57G20H32data;
linedata = lineE57;
fb = linedata(:,1);             % From bus number...
tb = linedata(:,2);             % To bus number...
r = linedata(:,3);              % Resistance, R...
x = linedata(:,4);              % Reactance, X...
b = linedata(:,5);              % Ground Admittance, B/2...
a = linedata(:,6);              % Tap setting value..
z = r + 1i*x;                    % z matrix...
y = 1./z;                       % To get inverse of each element...
b = 1i*b;                        % Make B imaginary...

nb = max(max(fb),max(tb));      % No. of buses...
nl = length(fb);                % No. of branches...
Y = zeros(nb,nb);               % Initialise YBus...
 
 % Formation of the Off Diagonal Elements...
 for k = 1:nl
     Y(fb(k),tb(k)) = Y(fb(k),tb(k)) - y(k)/a(k);
     Y(tb(k),fb(k)) = Y(fb(k),tb(k));
 end
 
 % Formation of Diagonal Elements....
 for m = 1:nb       %�ڵ����
     for n = 1:nl   %��·����
         if fb(n) == m
             Y(m,m) = Y(m,m) + y(n)/(a(n)^2) + b(n);
         elseif tb(n) == m
             Y(m,m) = Y(m,m) + y(n) + b(n);
         end
     end
 end
 
 
% function Y = ybusppg(numE)  % Returns Y
%  
% linedata = linedatas(numE);      % Calling Linedatas...
% [nl,~]=size(linedata);
% Y=zeros(numE,numE);                        % �Ե��ɾ��󸳳�ֵ0
% %linedata = linedatas(numE);      % Calling Linedatas...
% fb = linedata(:,1);             % From bus number...
% tb = linedata(:,2);             % To bus number...
% r = linedata(:,3);              % Resistance, R...
% x = linedata(:,4);              % Reactance, X...
% b = linedata(:,5);              % Ground Admittance, B/2...
% a = linedata(:,6);              % Tap setting value..
% 
% for k=1:nl   
%     I=fb(k);  
%     J=tb(k);   
%     Zt=r(k)+1j*x(k);          % ������·����
%     if Zt~=0
%         Yt=1/Zt;                       % �ӵ�֧·������Yt
%     end
%     Ym=b(k);   %j*line(k,6)   
%    
%     if (a(k)==0) && (J~=0)                   % ��ͨ��·: K=0
%         Y(I,I)=Y(I,I)+Yt+Ym;  
%         Y(J,J)=Y(J,J)+Yt+Ym;      
%         Y(I,J)=Y(I,J)-Yt;       
%         Y(J,I)=Y(I,J);   
%     end
%    
%     if (a(k)==0) && (J==0)                   % �Ե�֧·: K=0,J=0,R=X=0
%         Y(I,I)=Y(I,I)+Ym;   
%     end   
%    
%     if a(k)>0                             % ��ѹ����·: Zt��YmΪ���㵽i���ֵ,K��j��       
%         Y(I,I)=Y(I,I)+Yt+Ym;       
%         Y(J,J)=Y(J,J)+Yt/a(k)/a(k);       
%         Y(I,J)=Y(I,J)-Yt/a(k);       
%         Y(J,I)=Y(I,J);   
%     end   
%    
%     if a(k)<0                             % ��ѹ����·: Zt��YmΪ���㵽K���ֵ,K��i��       
%         Y(I,I)=Y(I,I)+Yt+Ym;       
%         Y(J,J)=Y(J,J)+a(k)*a(k)*Yt;       
%         Y(I,J)=Y(I,J)+a(k)*Yt;       
%         Y(J,I)=Y(I,J);   
%     end
% end