---
title: "Use replacement parameters to configure Unified Service Desk | MicrosoftDocs"
description: "Learn how to use replacement parameters in Unified Service Desk to customize amd personalize interactions through actions and window navigation rules."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Use replacement parameters to configure Unified Service Desk
Replacement parameters can be used for customizing interactions during a specific business process through actions and window navigation rules. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Replacement parameters](../unified-service-desk/replacement-parameters.md)  

 This topic provides information about the replacement keys that you can use in your replacement parameters to indicate special handling how you can use the replacement parameters in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] in some special conditions.  

<a name="ReplacementKeys"></a>   
## Replacement keys  
 The following table provides information about the replacement keys that you can use in your replacement parameters.  


| Replacement key |                                                                                                                                                                                                                                          Description                                                                                                                                                                                                                                           |
|-----------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|        +        |     This key, when present, will replace a null or non-existent key with an empty string.<br /><br /> For example: In the scenario where `account.name` is undefined, calling `[[account.name]]` would result in a “Not all parameters in action call *\<ActionName>* are available, aborting action call.” error. This will stop processing the rule or line item being executed.<br /><br /> However, `[[account.name]+]` will return a blank, and not raise the replacement key error.      |
|        $        |                                                                                                                                          This key allows escaping of quotes and line breaks. It is generally used as an operator when invoking a scriptlet or returning a multi-line string.<br /><br /> For example: `[[script.MyMultiLineString]$]`                                                                                                                                          |
|        ^        |                                                                                                                                                                    This key prevents escaping of quotes and line breaks, and is used to flatten multi-line result set.<br /><br /> For example: `MyMultiline=[[myvalue]^]`                                                                                                                                                                     |
|        u        |                                                                                        This key is used to URL Encode (also called Percent Encode) the replacement parameter.<br /><br /> For example, consider the replacement parameter in the following URL: https://mysite?something=`[[opportunity.name]u]`.<br /><br /> The following string is returned: https://mysite?something=My%20Opportunity.                                                                                        |
|        x        |                                                                                                                                                This key is used to XML encode the replacement parameter. The enables the XAML characters, such as <, to be escaped and display properly in the output.<br /><br /> For example, `[[myvalue]x]`.                                                                                                                                                |
|        g        |                                                                                                                                                                    This key is used to return the value from the global session. If the key cannot be found in the global session, it will result in a key not found error.                                                                                                                                                                    |
|        a        |                                                                                                                                                         This key is used to return value from the currently active session that is in focus. If the key cannot be found in the active session it will result in a key not found error.                                                                                                                                                         |
|        v        | This key is used to replace keys within a replacement key.<br /><br /> For example, consider the following two values:<br /><br /> -   account.name = "My Account"<br />-   mytemplate.value = "My template is `[[account.name]+]`"<br /><br /> When you invoke the `[[mytemplate.value]]`, the following string is returned: “My Template is [[account.name]+]".<br /><br /> However, when you invoke `[[mytemplate.value]v]`, the following string is returned: "My template is My Account". |

<a name="SpecializedHandlers"></a>   
## Specialized handlers  
 Often times, there is a need to do something simple, like an if/then/else type construct that does not warrant creating a scriptlet. These situations require using a scriptlet inside an action call. There are two specialized handlers to assist when building inline scriptlets in action calls: `$Expression` and `$Multiline`.  

### $Expression  
 Consider a situation where you need to switch display name based on the entity type code (etc) of the current entity. You are building a URL that needs this information. In this situation, there can only be either an account or contact loaded.  

 In this scenario, we are calling the **Navigate** action on a **Standard Web Application** hosted control by using the following value in the **Data** field:  

```  
url= https://mysite/showmessage.aspx?displayname={either the account or contact display name}  
```  

 To achieve this, we will use `$Expression` as follows:  

```  
url= https://mysite/showmessage.aspx?displayname=$Expression("[[$Context.etc]]" == "1" ? "[[account.name]u+]" : "[[contact.fullname]u+]")  
```  

 This effectively creates and runs a scriptlet as the action is processed.  

### $Multiline  
 In the $Expression section, we talked about doing an inline scriptlet within an action. In the situation where there is a need to do a more complex scriptlet, and you still do not want to use a scriptlet object to store the scriptlet, the $Multiline command can be used to store more complex scriptlets.  

 For example, using the example we used earlier in the `$Expression` section, it can be broken out as:  

```  
url= https://mysite/showmessage.aspx?displayname=$Multiline( $Expression(  
function doWork()  
{  
      If ("[[$Context.etc]]" == "1")  
          return "[[account.name]u+]"   
      else   
          return "[[contact.fullname]u+]"  
}  
doWork();   
))  
```  

### See also  
 [Replacement parameters](../unified-service-desk/replacement-parameters.md)   
 [Execute scripts using scriptlets in Unified Service Desk](../unified-service-desk/execute-scripts-using-scriptlets-unified-service-desk.md)   
 [Unified Service Desk Configuration Walkthroughs](../unified-service-desk/unified-service-desk-configuration-walkthroughs.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]