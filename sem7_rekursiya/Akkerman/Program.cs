using System.Globalization;

static int Akkerman(int n, int m){
    if(n==0)
    return m+1;
    else if (m==0)
    return Akkerman(n-1, 1);
    else
    return Akkerman(n-1, Akkerman(n, m-1));
}
int a=2, b=2;
int c = Akkerman( a,b );


// void Akkerman(int a, int b, int i = 0, double sum=-1, int c = 4, int j=2){
//     switch (i) {
//         case 0:
//             Console.WriteLine(a+b);
//             i++;
//             Akkerman(a, b, i);
//             break;
//         case 1:
//             Console.WriteLine(a*b);
//             i++;
//             Akkerman(a, b, i);
//             break;
//         case 2:
//             if (j < c)
//             {
//                 if (sum == -1)
//                 {
//                     sum = a;
//                 }
//                 sum = Math.Pow(sum, b);
//                 Console.WriteLine(sum);
//                 j++;
//                 Akkerman(a, b, i, sum, c, j);
//                 break;
//             }
//             break;
//     }
// }
Console.WriteLine(c);