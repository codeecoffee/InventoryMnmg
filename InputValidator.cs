public static class InputValidator
{
    public static bool ValidateNumFields(params (string input, string fieldName)[] fields)
    {
        foreach (var field in fields)
        {
            //if (!int.TryParse(field.input, out _) && !decimal.TryParse(field.input, out _))
            //{
            //    MessageBox.Show($"Please enter a valid number for {field.fieldName}");
            //    return false;
            //}
            if (!decimal.TryParse(field.input, out decimal result))
            {
                MessageBox.Show($"Please enter a valid number for {field.fieldName}.");
                return false;
            }
            if (result < 0)
            {
                MessageBox.Show($"{field.fieldName} cannot be negative");
                return false;
            }

        }
        return true;
    }
}

