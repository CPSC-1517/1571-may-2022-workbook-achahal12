using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public class Employment
    {
        //an instance of this class will hold data about a person's 
        //employment
        // the code of this class is the definition of the that data
        // The characteristics (data) of the class
        // Title, SupervisorLavel, Years of employment within the company 

        // there are 4 component of the class definition
        // data fields (data members)
        //property
        //constructor
        //behaviour(method)

        //data fields
        //are stronge areas in your class
        //these are treated as variables
        //these may be public, private, public readonly
        private string _Title;
        private double _Years;

        //property
        //These are access techniques to retrieve or set data in
        //your class without directly touching the stronge data field

        // A property is public so it can be access by an outside user 
        //of the class
        // A property MUST have a get
        // A property MAY have a set
        // if no set, the property is not changable by the user; readonly
        // commonly used for calculted data of the class
        // the set can be either public or private
        //      Public: the user can alter the contents of the data
        //      Private: only code within the class can alter the contents

        // fully implemented property
        // a) a delclered storage area (data field)
        // b) a delclared property signature (access return data type propertyname)
        // c) a coded accessor (get) coding block : public
        // d) an optional coded mutator (set) coding block : public or private 
        //      if the set is private the only way to place data into this property is
        // via the constructor or a behaviour (method)


        // When:
        // a) if you are storing the associate data in an explicitly declared data field
        // b) if you are doing validation on incoming data
        // c) creating a property that generates output from other data sources
        //      within the class (readonly property); this property would ONLY have a
        // accessor (get)

        public string Title

        {
            // a property is associted with a single piece of data
            get

            {
                // accessor
                //the get "coding block" will return the contents of a data field(s)
                // the return has syntex of return expression
                return _Title;

            }

            private set
            {
                // mutator
                // the set "coding block" recives an incoming value and places it into the
                // associted data field
                // during the setting , you might wish to validate the incoming data
                // during the setting, youo might wish to da some type of logical 
                // processing using the data to set another field
                // the incoming pieece of data is referred to using the keyword "value"

                //ensure that the incoming data is not null or empty or just whitespace 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is a required piece of data.");
                }

                // data is consider valid
                _Title = value;
            }
        }

        // auto implemented property

        // these properties differ only in syntax
        // each property is responsible for a single piece of data
        // these properties do NOT reference a declared private data member
        // the system generates an internal storage area of the return data type
        // the system manages the internal strorage for the accessor and mutator
        // There is NO ADDITIONAL LOGIC APPLIED TO THE DATA VALUE!!!!!!!!

        // USING an enum for this field will automatically restrict the values
        // this property can contain

        // syntex access return data type propertyname {get; [private] set;}

        public SupervisoryLevel Level { get; set; }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentOutOfRangeException($"years of {value} is invalid. Must be 0 or greater ");
                }
                _Years = value;
            }
        }

        // Constructor

        // this is used to initialize the physical object ( instance) during its creating
        //the result of creation is to ensure that the coder gets an instance in a 
        // "Known state"
        // 
        // if your class defination has NO constructor coded, the data members and/or
        // auto implement properties are set to the C# defult date type value

        //you can code or more constructors in your class defination
        //  IF YOU CODE A CONSTRUCTOR FOR THE CLASS, YOU ARE RESPONSIBILE FOR ALL
        // CONSTRUCTORES USED BY THE CLASS!!!!!!

        // generally, if you are going to code your own constructores you code two types
        //
        //Defult: this constructores does NOT take in any parameters
        //          this constructor mimics the defult system constructores
        // Gready: this constructor has a list of parameters, one for each property.
        //          declare for incoming date
        // (),(a), (b),(c), (d),(a,b)(a,c)(a,d).....2 raise power of 4 = 16 constructor
        //()(a,b,c,d)
        //
        //Syntex: accasstype classname([list of parameters]) {constructor code block}
        //
        // IMPORTANT: the constructor DOES NOT have a return datatype
        //              you DO NOT call a consteuctor directly, it is called using the
        //              new command =>      new classname (......);
        //
        //Defult constructor

        public Employment()
        {

            // constructor body
            // a) empty: values will be set to C# defults
            // b) you COULD assign literal values to your properties with this constructor

            // the vaules that you give your class data members/propertied CAN be assigned
            //      directly to a data member.
            // HOWEVER: if you have validated properties, you SHOULD consider saving your
            //      data values via the property

            // you CAN code your validation logic within your constructors BECAUSE object
            // run your constructor when it is created.
            //placing your logic in the constructor could be done if your property has //
            // a private set OR if your public data member is a readonly data member 
            //
            //private sets and readonly data member CANNOT have their data altered directly

            Level = SupervisoryLevel.TeamLeader;
            Title = "Unknown";

        }


        //Greedy constructor

        public Employment(string title, SupervisoryLevel level, double years=0.0)
        {
            // 

            //constrouctor body
            // a) a parameter for each property
            // b) you COULD your validation in this constrouctor
            // c) validattion for public readonly data member AND
            //      validation for properties with a private set MUST be done here
            //      if not done in the property

            //defult parameters

            //WHY? it allows the programer to use your constructor/method with having to 
            //specify all argument in the code to your constructor/method

            //Location: end of parameter list
            //How many: as many as you wish
            //values for your defult parameters MUST be a vaild value
            //position and order of specified defult parameters are important when the
            //program uses the constructor/method.
            // defult parameterd CAN be skipped , HOWEVER, you still must account for the 
            //skipped parameter in your argument cal list using commas
            //by giving the defult parameter an argumant value on the call, the constructor/method
            //defult value is overridden

            // syntex: data type parametername= defult value
            //exemple: years on this constructor is a defult parameter

            //exemple: skipped defultd (3 defult parameters, 2 one skipped
            //(string requiredparam, int requiredparam. int defult1, int defult 3
            //      int defult 2 = 0,int defult 3 = 1)
            //
            //call:....("required string " 25, 10, 5) default2 was skipped

            Title = title;
            Level = level;
            Years = years;  //eventually the data will be placed in _years


        }


        //Behaviours (a.k.a methods)
        //a behaviour is any method in your class
        // behaviours can be private (for use by the class only); public (for use by the outside user)
        //all rules about methoss are in effect

        // a spacial method may be placed in your class to reflect the data stored by the 
        //instance (object) based on this class defination
        // this methos is part of the system software and can be overriden by your own
        //version of the method

        public override string ToString()
        {
            //this string is known as a "comma separate values (csv)"string
            //this string uses the get; of the property
            return $"{Title},{Level},{Years}";

        }

        public void SetEmploymentResponsibilityLevel(SupervisoryLevel level)
        {
            // this method, in this exemple would not be necessary as the access directly
            //the level (property ) is public(set;)
            //HOWEVER: if the level property had a private set; the outsider user would NOT 
            //have direct access to changing the property.
            //THERFOR: a method (besides the constructor) would need to be supplied to allow
            // the outside user the ability to alter the property value(if they so desired)
            
            //this assignment uses the set; of the property
            Level = level;
        }

    }  //eoc
}  //eon
