﻿using System.Collections.Generic;

namespace DistribuisciEsamiCommon
{
    public class Punteggi
    {
        public Dictionary<decimal, List<int>> punteggi;
        public List<List<int>> rank;

        public Punteggi()
        {
            this.punteggi = new Dictionary<decimal, List<int>>();
        }

        public void CalcolaRank()
        {
            rank = new List<List<int>>();
            List<decimal> rankValue = GetRankValue();
            foreach (var i in rankValue)
            {
                rank.Add(punteggi[i]);
            }
        }

        private List<decimal> GetRankValue()
        {
            List<decimal> r = new List<decimal>();
            foreach (var i in punteggi.Keys)
            {
                r.Add(i);
            }

            r.Sort();

            return r;
        }
    }
}