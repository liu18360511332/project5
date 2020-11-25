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
 for m = 1:nb       %节点个数
     for n = 1:nl   %线路个数
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
% Y=zeros(numE,numE);                        % 对导纳矩阵赋初值0
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
%     Zt=r(k)+1j*x(k);          % 读入线路参数
%     if Zt~=0
%         Yt=1/Zt;                       % 接地支路不计算Yt
%     end
%     Ym=b(k);   %j*line(k,6)   
%    
%     if (a(k)==0) && (J~=0)                   % 普通线路: K=0
%         Y(I,I)=Y(I,I)+Yt+Ym;  
%         Y(J,J)=Y(J,J)+Yt+Ym;      
%         Y(I,J)=Y(I,J)-Yt;       
%         Y(J,I)=Y(I,J);   
%     end
%    
%     if (a(k)==0) && (J==0)                   % 对地支路: K=0,J=0,R=X=0
%         Y(I,I)=Y(I,I)+Ym;   
%     end   
%    
%     if a(k)>0                             % 变压器线路: Zt和Ym为折算到i侧的值,K在j侧       
%         Y(I,I)=Y(I,I)+Yt+Ym;       
%         Y(J,J)=Y(J,J)+Yt/a(k)/a(k);       
%         Y(I,J)=Y(I,J)-Yt/a(k);       
%         Y(J,I)=Y(I,J);   
%     end   
%    
%     if a(k)<0                             % 变压器线路: Zt和Ym为折算到K侧的值,K在i侧       
%         Y(I,I)=Y(I,I)+Yt+Ym;       
%         Y(J,J)=Y(J,J)+a(k)*a(k)*Yt;       
%         Y(I,J)=Y(I,J)+a(k)*Yt;       
%         Y(J,I)=Y(I,J);   
%     end
% end