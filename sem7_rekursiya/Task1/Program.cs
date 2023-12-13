int m = 1, n=18;

void Programm1(int m, int n, int i=0, int cur=0){
    cur=m+i;
    if(i<n){
        Console.Write(cur+"\t");
        i++;
        Programm1(m,n,i);
    }
}

Programm1(m,n);