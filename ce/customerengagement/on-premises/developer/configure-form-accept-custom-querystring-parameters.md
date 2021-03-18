---
title: "Configure a form to accept custom querystring parameters (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about configuring a form to acept custom querystring parameters. Use these parameters to set default values when you create a new record in the application."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6c05ff14-2d5a-4e90-a3c4-dc7ca1ec4698
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure a form to accept custom querystring parameters

The ability to pass values to a Web page by using query strings represents a concern for security. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] applies the best practice of always comparing any parameter passed as a query string against a list of expected parameter names and data types.  
  
 By default, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] allows a specified set of query string parameters to be passed to a form. You use these parameters to set default values when you create a new record in the application. Each parameter must use a standard naming convention that includes a reference to the attribute logical name. For more information, see [Set field values using parameters passed to a form](set-field-values-using-parameters-passed-form.md).  
  
 In your applications, you may want to pass custom query string parameters to an entity form. This topic provides information about how you can define a set of specific parameter names and data types that can be accepted for a specific entity form.  
  
## Define allowed query string parameters  
 There are two ways to specify which query string parameters will be accepted by the form:  
  
-   Edit form properties  
  
-   Edit form XML  
  
### Edit form properties  
 When you edit an entity form, on the **Home** tab in the **Form** group, click **Form Properties**. In the **Form Properties** dialog box, select the **Parameters** tab.  
  
 Use this tab to modify the names and data types that the form allows.  
  
### Edit FormXml  
 Within the exported solution customizations.xml file, immediately following the footer element, you can add a `<formparameters>` element. In the `<formparameters>` element, add `<querystringparameter>` elements to specify which parameters will be allowed.  
  
 The following describes the `querystringparameter` element attributes, `name` and `type`:  
  
- **name**. Each name attribute must contain at least one underscore ('\_') character, but the name of the query string parameter cannot begin with an underscore. The name also can’t start with “crm\_”. We strongly recommend that you use the customization prefix of the solution publisher as the naming convention. A valid `querystringparameter` name attribute value is “myISV_contact_specialvalue”.  
  
    > [!IMPORTANT]
    >  If a `querystringparameter` element name is not unique, it may be overwritten by another parameter definition using a different data type.  
  
- **Type**. Match the data type values with the parameter values so that invalid data is not passed with the parameter. The following are valid data types:  
  
    -   Boolean  
  
    -   DateTime  
  
    -   Double  
  
    -   EntityType  
  
    -   Integer  
  
    -   Long  
  
    -   PositiveInteger  
  
        > [!NOTE]
        >  PositiveInteger includes “0” in the range of valid values.  
  
    -   SafeString  
  
    -   UniqueId  
  
    -   UnsignedInt  
  
### See also  
 [Set field values using parameters passed to a form](set-field-values-using-parameters-passed-form.md)   
 [Open Forms And Views with a URL](open-forms-views-dialogs-reports-url.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]