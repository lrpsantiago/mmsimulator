using System.Windows.Forms;

namespace MoneyManagementSimulator
{
    public static class DialogUtil
    {
        public static void ShowMessage(string text)
        {
            MessageBox.Show(text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirm(string question)
        {
            var result = MessageBox.Show(question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
    }
}
