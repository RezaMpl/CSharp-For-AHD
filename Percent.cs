        public void Percent(int max, int f, int a)
        {
            string m = "";
            double b = a;
            int c = 0;
            if (c == a)
                c = a;
            if (c != a)
            {
                m = File.ReadAllText("Config.cfg");
                c = int.Parse(m);
            }
            if (a == c)
            {
                b = (b / max) * (100);
                Console.WriteLine(Math.Floor(b) + "%");
                c = c + f;
            }
            File.WriteAllText("Config.cfg", c.ToString());
        }
        public double D(int max, int a)
        {
