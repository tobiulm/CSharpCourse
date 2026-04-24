using NewElements.DemoLibrary;

namespace DemoLibraryTestProjekt
{
    public class MitarbeiterTests
    {
        [Fact]
        public void TestAufMindestAlter()
        {
            Assert.Throws<MitarbeiterZuJungException>(delegate
            {
                Mitarbeiter emp = new Mitarbeiter();
                emp.GeburtsDatum = new DateOnly(2015, 1, 1);
            });
        }

        [Fact()]
        public void TestAufMidestAlterPositiv()
        {
            Mitarbeiter emp = new Mitarbeiter();
            emp.GeburtsDatum = new DateOnly(2005, 1, 1);

            Assert.True(DateTime.Now.Year - emp.GeburtsDatum.Year > 16);
        }
    }
}