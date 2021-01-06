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
                // no comment
