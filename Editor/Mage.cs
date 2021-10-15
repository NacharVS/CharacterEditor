using System;
using System.Collections.Generic;
using System.Text;

namespace Editor
{
   public class Mage
    {
        public Mage(string nameclass,int str, int dox, int intelegence, int constit,  int p_damage, int m_damage,int lvl)
        {
            strenght = str;
            this.dox = dox;
            this.intelligence = intelegence;
            this.constiti = constit;
            Class = nameclass;
            this.p_damage = p_damage;
            this.m_damage = m_damage;
            this.lvl = lvl;
        }
        public int m_damage;
        public int p_damage;
        public int strenght;
        public int dox;
        public int intelligence;
        public int constiti;
        public string Class;
        public int lvl;
    }
}
