using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otzig
{
    class Algoritm
    {
        int[] _ferzC;//текущее
        int _N;

        const double Tn = 30.0;
        const double Tk = 0.5;
        const double alfa = 0.98;
        const int st = 20000;

        int[] _ferzW;//рабочее
        int[] _ferzB;//лучшее
        int energyC;//текущее
        int energyW;//рабочее
        int energyB;//лучшее
        double t, delta, P;
        bool fNew, fBest;
        int time, accepted;

        public Algoritm(int[] ferzC, int N)
        {
            _ferzC = new int[N];
            _ferzW = new int[N];
            _ferzB = new int[N];
            _N = N;
        }

        private void Swap(ref int[] mas)
        {
            int x, y, v;
            Random rand = new Random();
            x = rand.Next(_N);
            do
            {
                y = rand.Next(_N);
            } while (x == y);
            v = mas[x]; mas[x] = mas[y]; mas[y] = v;
        }

        private void CalcEnergy(int[] mas, ref int energy)
        {
            int[] dx, dy;
            int tx, ty, error;

            error = 0;
            dx = new int[4] { -1, 1, -1, 1 };
            dy = new int[4] { -1, 1, 1, -1 };
            for (int i = 0; i < _N; i++)
                for (int j = 0; j < 4; j++)
                {
                    tx = i + dx[j]; ty = mas[i] + dy[j];
                    while ((tx >= 0) && (tx < _N) && (ty >= 0) && (ty < _N))
                    {
                        if (mas[tx] == ty)
                            error++;
                        tx += dx[j];
                        ty += dy[j];
                    }
                }
            energy = error;
        }

        private void CopyMas(ref int[] masD, ref int[] masS, ref int energyD, ref int energyS)
        {
            for (int i = 0; i < _N; i++)
                masD[i] = masS[i];
            energyD = energyS;
        }

        public void Start(ref string outText, ref int[] _ferzC, ref int energy)
        {
            Random rand = new Random();
            t = Tn;
            fBest = false;
            time = 0;
            energyB = 100;
            for (int i = 0; i < _N; i++)
                Swap(ref _ferzC);
            CalcEnergy(_ferzC, ref energyC);
            CopyMas(ref _ferzW, ref _ferzC, ref energyW, ref energyC);
            while (t > Tk)
            {
                accepted = 0;
                for (int i = 0; i < st; i++)
                {
                    fNew = false;
                    Swap(ref _ferzW);
                    CalcEnergy(_ferzW, ref energyW);
                    if (energyW <= energyC)
                        fNew = true;
                    else
                    {
                        delta = energyW - energyC;
                        P = Math.Exp(-delta / t);
                        if (P > rand.NextDouble())
                        {
                            accepted++;
                            fNew = true;
                        }
                    }
                    if (fNew)
                    {
                        fNew = false;
                        CopyMas(ref _ferzC, ref _ferzW, ref energyC, ref energyW);
                        if (energyC < energyB)
                        {
                            CopyMas(ref _ferzB, ref _ferzC, ref energyB, ref energyC);
                            fBest = true;
                        }
                    }
                    else
                        CopyMas(ref _ferzW, ref _ferzC, ref energyW, ref energyC);
                }
                outText += "T= " + t + "    E= " + energyB + "\n";
                t *= alfa;
                time++;
            }
            energy = energyB;
            for (int i = 0; i < _N; i++)
                _ferzC[i] = _ferzB[i];
        }
    }
}
