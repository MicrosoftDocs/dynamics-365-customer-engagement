---
title: Special field properties for Main forms (Dynamics 365 Customer Engagement) | MicrosoftDocs
description: Understand the special field properties for Main forms in Dynamics 365 for Customer Engagement
Keywords: Main forms; Special field properties; Dynamics 365
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 03/09/2018
ms.service: crm-online
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6ad7e43c-b6a1-48c4-9dfb-ed830142a841
---
# Special field properties

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 All fields have the properties listed in [Common field properties](../customize/common-field-properties-legacy.md), but certain fields have additional properties.  
  
<a name="BKMK_LookupFieldProperties"></a>  
 
### Lookup field properties  
 On the **Display** tab, lookup fields have some additional properties. Some system fields that look like lookup fields and have similar behaviors are Owner, Customer, PartyList and Regarding lookups. These fields are different from lookups because they allow for setting multiple values or multiple types, or both. These fields have only the first two properties: **Turn off automatic resolutions in the field** and **Disable most recently used items for this field**.  
  
 This is an example of the lookup dialog shown when people click the **Look Up More Records** option when setting the value for a lookup.  
  
 ![Lookup dialog box elements in Dynamics 365](../customize/media/crm-itpro-cust-lookupdialog.PNG "Lookup dialog box elements in Dynamics 365")  
  
|Property|Description|  
|--------------|-----------------|  
|**Turn off automatic resolutions in the field**|Only main forms using the [Classic forms](main-form-presentations.md#classic-forms) support automatic resolution. This can be disabled with this setting.|  
|**Disable most recently used items for this field**|Only main forms using the [Classic forms](main-form-presentations.md#classic-forms) support most recently used items. This can be disabled with this setting.|  
|**Related Records Filtering**|When this is enabled the records displayed when someone searches for a record will have additional filtering applied. This helps provide more relevant searches when setting the value of the lookup.<br /><br /> You can also allow users to turn off the filter.|  
|**Display Search Box in lookup dialog**|You can choose not to display the search box in the lookup dialog.|  
|**Default View**|This view will be used to filter the results of the inline search and specify the default view shown in the lookup dialog if people choose the **Look Up More Records** option.<br /><br /> The default view also controls which fields are included in the inline lookup.<br /><br /> ![Inline lookup in Dynamics 365](../customize/media/crm-itpro-cust-inlinelookup.PNG "Inline lookup in Dynamics 365")<br /><br /> For lookups that only allow selection of a single type of entity, the fields displayed in the inline lookup are set to be the first two fields included in the default view. In this example, **Main Phone** and **Email** are the first two columns in the default view configured for an account lookup.<br /><br /> For system lookups that allow for multiple types of entities, the first two columns of the entity lookup view are shown.|  
|**View Selector**|You can choose from three options:<br /><br /> - **Off**: Do not allow people to choose a different view.<br />- **Show All Views**; All views are available.<br />- **Show Selected Views**: When you choose this option you can use the Ctrl key and your cursor to choose which views to show. The Lookup view for the entity cannot be de-selected.|  
  
<a name="BKMK_TwoOptionProperties"></a>   

### Two option field properties  
 On the formatting tab, two option fields have the following formatting options  
  
- **Two radio buttons**: Two labeled controls with labels. Only one may be selected.  
  
- **Checkbox**: A single checkbox to set the true value, otherwise false.  
  
- **List**: A drop-down list containing both values.  
  
<a name="BKMK_MultipleLinesOfTextProperties"></a>   

### Multiple lines of text field properties  
 Multiple lines of text and single line of text fields that use the `Text Area` format have a **Row Layout** property. With this property you can specify a value for **Number of Rows** or select **Automatically expand to use available space**.  

## See also

[Use the Main form and its components](../customer-service/use-main-form-and-components.md)
