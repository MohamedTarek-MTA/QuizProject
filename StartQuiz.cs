private void StartQuizbtn_Click(object sender, EventArgs e)
{
   if(!String.IsNullOrWhiteSpace(Nametxtbox.Text) && !String.IsNullOrWhiteSpace(IDtxtbox.Text))
    {
        string userName = Nametxtbox.Text;
        string Id = IDtxtbox.Text;
        Quiz quiz = new Quiz(userName , Id);
        quiz.Show();
    }
    else
    {
        MessageBox.Show("Please Enter Your Name And Your ID!");
    }
    
}
