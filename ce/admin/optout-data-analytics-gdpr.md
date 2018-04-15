---
title: "Opt out of data analytics (GDPR) (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "Opt out to ensure that no analytics is performed on your data when using Embedded Intelligence."
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/18/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6f86a039-15cc-46aa-b6fb-8dd8260de0ba
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# Opt out of data analytics (GDPR)

Applies to Dynamics 365 (online), version 9.0.2

A new field or attribute called **msdyn_gdproptout** (display name: **GDPR Optout**) is added to the Contact, Lead, and SystemUser entities when you [enable](configure-enable-embedded-intelligence.md) the Embedded Intelligence feature. The field lets you specify whether analytics will be performed on the entity record's data.

- Setting the **GDPR Optout** field to "yes/true" will prohibit any analytics to be performed on the entity record's data.
- Setting the **GDPR Optout** field to "no/false" will allow analytics to be performed on the entity record's data.

## Setting the GDPR Optout field using UI

By default, the **GDPR Optout** field is not available on the Contact, Lead and SystemUser forms. You can customize the form to display the **GDPR Optout** field for these entities so that one can easily set an appropriate value in this field for a record. By default, the value is set to **No** (false) for this field when you create a new record.

![](media/gdpr-optout-field.png)

For information about adding field to a form, see [Add a field to a form](../customize/add-field-form.md)

## Setting the msdyn_gdproptout attribute value using code

You can also programmatically set or update the value of the **msdyn_gdproptout** attribute by using Web API or Organization service.
- **Web API**: When you want to update only a single attribute value for an entity record, use a PUT request with the property name appended to the Uri of the entity. The following example demonstrates how to update the `msdyn_gdproptout` attribute value to **true** of a contact record with the `contactid` value as 00000000-0000-0000-0000-000000000001.

    ```http
    PUT [Organization URI]/api/data/v9.0/contacts(00000000-0000-0000-0000-000000000001)/msdyn_gdproptout HTTP/1.1  
    Content-Type: application/json  
    OData-MaxVersion: 4.0  
    OData-Version: 4.0  

    {"value": true}
    ```

    For more information about updating records using Web API, see [Update and delete entities using the Web API](../developer/webapi/update-delete-entities-using-web-api.md)

- **Organization service**: You can use the early or late bound programming style to update an attribute. The following example demonstrates how to update the `msdyn_gdproptout` attribute value to **true** for a contact record using late bound programming style.

    ```csharp  
    Entity contact = new Entity("contact");  
    
    // Create a column set to define which attribute should be retrieved.  
    ColumnSet attributes = new ColumnSet("msdyn_gdproptout");   
  
    // Retrieve the contact and its msdyn_gdproptout attribute.  
    contact = _orgService.Retrieve("contact", _contactId, attributes);  
  
    // Update the msdyn_gdproptout attribute value.  
    contact["msdyn_gdproptout"] = true;  
  
   // Update the contact record.  
   _orgService.Update(contact);  
    ```

For more examples of using the early or late bound programming style, see [Use the early-bound entity classes for create, update, and delete](../developer/org-service/use-early-bound-entity-classes-create-update-delete.md) and [Use the Entity class for create, update and delete](../developer/org-service/use-entity-class-create-update-delete.md).


### See also

[Embedded Intelligence and GDPR](embedded-intelligence-gdpr.md)