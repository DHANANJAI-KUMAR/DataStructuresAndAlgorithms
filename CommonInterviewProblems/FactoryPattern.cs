
namespace CommonInterviewProblems
{
    public enum DocumentType
    {
        PDF,
        DOC,
    }
    public interface IDocument 
    {
	    void CreateDocument();
    }
    public class GenratePDF : IDocument{
        public void CreateDocument(){	}
    }

    public class GenrateDoc : IDocument{
	    public void CreateDocument() {	}
    }

    public class ClientClass
    {
        public ClientClass()
        {
            FactoryPattern fp = new FactoryPattern();
            IDocument dt = fp.DocumentInstance(DocumentType.PDF);
            dt.CreateDocument();
        }
    }

    public class FactoryPattern
    {
        public FactoryPattern()
        {
            // Initialize resources if needed
        }

        public IDocument DocumentInstance(DocumentType documentType)
        {
            IDocument dt;
            switch (documentType)
            {
                case DocumentType.PDF:
                    dt = new GenratePDF();
                    break;
                case DocumentType.DOC:
                        dt = new GenrateDoc();
                        break;
                default: dt = null;
                    break;
            }

            return dt;

        }
    }


}