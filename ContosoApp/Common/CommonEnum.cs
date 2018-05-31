using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoApp.Common
{
    //Primary type of person: SC = Store Contact, IN = Individual(retail) customer, SP = Sales person, EM = Employee(non - sales), VC = Vendor contact, GC = General contact
    public enum PersonType
    {
        [Description("Store Contact")]
        SC,
        [Description("Individual(retail) customer")]
        IN,
        [Description("Sales person")]
        SP,
        [Description("Employee(non - sales)")]
        EM,
        [Description("Vendor contact")]
        VC,
        [Description("General contact")]
        GC
    }
    // 0 = The data in FirstName and LastName are stored in western style(first name, last name) order.  1 = Eastern style(last name, first name) order.
    public enum NameStyle
    {
        [Description("Western style")]
        WS,
        [Description("Eastern style")]
        ES
    }
    //0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. 
    public enum EmailPromotion
    {
        [Description("Contact does not wish to receive e-mail promotions")]
        DoesNotReceive,
        [Description("Contact does wish to receive e-mail promotions from AdventureWorks")]
        Receive,
        [Description("Contact does wish to receive e-mail promotions from AdventureWorks and selected partners")]
        ReceiveWithPartner
    }

}
