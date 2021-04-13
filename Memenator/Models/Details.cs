using System;
using System.Collections.Generic;


namespace Memenator.Models
{
     public class Details
    {
       public String template_id { get; set; }
public String username { get; set; }
public String password { get; set; }

public String text0 { get; set; }
public String text1 { get; set; }

public Details(String template_id, String username, String password, String text0, String text1)
{
 this.template_id = template_id;
 this.username=username;
 this.password=password;
 this.text0 = text0;
 this.text1 = text1;
}


    }
}
