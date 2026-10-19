namespace C__Advanced_session01.MultiplieConstriant;

internal class AnimalBox <T> where T : Animal , Ishowable , new()
{
    #region Q12

    public void ShowItem(T item)
    {
        item.Show();
    }
    #endregion
}
