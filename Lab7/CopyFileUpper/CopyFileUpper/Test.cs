USING SYSTEM;
USING SYSTEM.IO;
USING SYSTEM.COLLECTIONS.GENERIC;
USING SYSTEM.LINQ;
USING SYSTEM.TEXT;
USING SYSTEM.THREADING.TASKS;

NAMESPACE ITMO.CSCOURSE2021.LABS.LAB07.E3.COPYFILEUPPER
{
    CLASS COPYFILEUPPER
    {
        STATIC VOID MAIN(STRING[] ARGS)
        {
            STRING SFROM, STO;
            STREAMREADER SRFROM;
            STREAMWRITER SWTO;

            CONSOLE.WRITE("COPY FROM:");
            SFROM = CONSOLE.READLINE();

            CONSOLE.WRITE("COPY TO:");
            STO = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY FROM {0} TO {1}", SFROM, STO);
            TRY
            {
                SRFROM = NEW STREAMREADER(SFROM);
                SWTO = NEW STREAMWRITER(STO);

                WHILE(SRFROM.PEEK() != -1)
                {
                    STRING SBUFFER = SRFROM.READLINE();
                    SBUFFER = SBUFFER.TOUPPER();
                    SWTO.WRITELINE(SBUFFER);
                }
                SWTO.CLOSE();
                SRFROM.CLOSE();

            }
            CATCH(FILENOTFOUNDEXCEPTION)
            {
                CONSOLE.WRITELINE("INPUT FILE NOT FOUND!");
            }
            CATCH(EXCEPTION E)
            {
                CONSOLE.WRITELINE("UNEXPECTED EXCEPTION");
                CONSOLE.WRITELINE(E.TOSTRING());
            }
        }

    }
}
