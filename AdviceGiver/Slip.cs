﻿namespace AdviceGiver
{
    public class AdviceSlip
    {
        public Slip slip { get; set; }
        
        
    }

    public class Slip
    {
        public int id { get; set; }

        public string advice { get; set; }
    }
}
