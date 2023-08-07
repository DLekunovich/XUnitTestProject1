using Xunit;
using WpfApp2;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private static IMainWindowActions mainWindowActions;

        private MainWindowViewModel viewmodel = new MainWindowViewModel(mainWindowActions);

        [Fact]
        public void LengthOfProcessText()
        {
            
            viewmodel.ProcessText = "aaaa";

            Assert.Equal(4, viewmodel.ProcessText.Length);
        }

    }
}
