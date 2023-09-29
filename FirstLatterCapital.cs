public void Capitalization(){
TextInfo text = new CultureInfo("",false).TextInfo;
            string str = "im jack";
            string[] str2 = str.Split(' ');
            for (int i = 0; i < str2.Length; i++)
                str2[i] = text.ToTitleCase(str2[i]);
            Console.WriteLine(string.Join(' ',str2));
}
