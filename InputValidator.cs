public static class InputValidator
{
    public static bool ValidateNumFields(params (string input, string fieldName)[] fields)
    {
        foreach (var field in fields)
        {
            if(string.IsNullOrEmpty(field.input))
            {
                MessageBox.Show($"{field.fieldName} cannot be empty");
                return false;
            }
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

