        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindText.Text != "")
            {
                int FindTextLength = txtFindText.Text.Length;
                String FindText = txtFindText.Text.ToString();
                String FoundText = "";
                for (int i = 0; i < txtString.Text.Length; i++)
                {
                    FoundText = funSubString(i, FindTextLength, txtString.Text.ToString());
                    if (FoundText == FindText)
                    {
                        break;
                    }
                }
                MessageBox.Show(FoundText);
                //int iBin = int.Parse(FoundText);
                //String Binary = Convert.ToString(iBin, 2).ToString();
                //MessageBox.Show(Binary);
            }
        }
        public string funSubString(int s, int l, string test)
        {
            char[] narray = new char[l];
            for (int i = 0; i < l; i++)
            {
                narray[i] = test[s + i];
            }
            string result = new string(narray);
            return result;
        }
