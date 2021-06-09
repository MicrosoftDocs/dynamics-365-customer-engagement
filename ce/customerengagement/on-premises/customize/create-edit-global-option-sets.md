---
title: "Create and edit global option sets with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: Learn how to create and edit option sets
ms.custom: 
ms.date: 03/06/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: f06b8941-8dca-4601-b965-341cfb6fc3b2
caps.latest.revision: 11
ms.author: matp
manager: kvivek
author: Mattp123
search.audienceType: 
  - customizer

---
# Create and edit global option sets (picklists)

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create an Option set](/powerapps/maker/common-data-service/custom-picklists)

An option set is a type of field that can be included in an entity. It defines a set of options. When an option set is displayed in a form it uses a drop-down list control. When displayed in Advanced Find it uses a picklist control. Sometimes option sets are called picklists by developers.  
  
 You can define an option set to use a set of options defined within itself (locally) or it can use a set of options defined elsewhere (globally) which can be used by other option set fields. Global option sets are useful when you have a standard set of categories that can apply to more than one entity. Maintaining two separate option sets with the same values is difficult and if they are not synchronized you can see errors, especially if you are mapping entity fields in a one-to-many entity relationship. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Mapping entity fields](../customize/map-entity-fields.md#BKMK_mappingEntityFields)  
  
<a name="BKMK_Configuring"></a>   
## Configure global option sets  
  
#### Create a global option set  
  
1.  Go to **Settings** > **Customizations** > **Customize the System**.  
  
2.  In the solution explorer, choose **Option Sets**.  
  
3.  On the actions toolbar choose **New**.  
  
4.  Enter a **Display Name** and (optionally) a **Description**.  
  
     The **Name** field value will be generated based on the value of the **Display Name** you enter.  
  
     The **Name** field value will include the customization prefix for the solution publisher for the solution you are working in. If the customization prefix is important to you, make sure you are working in the context of a solution that has the customization prefix you want for this global option set. See [Change the solution publisher prefix](../customize/change-solution-publisher-prefix.md) for information about how to change the customization prefix.  
  
     The **Name** field value must be unique. If the generated value is the same as an existing global option set, you will need to change it before you can save.  
  
5.  Unlike the **Description** for fields, the **Description** value for a global option set is not displayed as a tooltip when the field is used in a form. This description is only visible in the list of global options. You can use the description to provide information about why you have created this global option set and what it should be used for.  
 
> [!NOTE]
> The fields **External Type Name** and **External Value** are only used if you are using virtual entities. If you are not using virtual entities, these fields can be left blank. For more information, see [Create and edit virtual entities that contain data from an external data source](create-edit-virtual-entities.md) 
 
6.  In the toolbar choose **Save** to save the global option set. You can then edit the options in the option set using the instructions below.  
  
#### Edit a global option set  
  
1.  Choose **Customize the System**.  
  
2.  In the solution explorer, choose **Option Sets**.  
  
3.  Double-click one of the existing option sets to open it.  
  
4.  You can edit the **Display Name** or **Description** fields, but editing the options is the most common reason to edit a global option set.  
  
##### Edit option set options  
In the **Options** section you can create, edit, delete, and change the order in which options are presented.  
  
###### Create new options  
1. Choose the green **+** icon to create an option.  
  
2. Each option you create will have a **Label** value of **Item** and a **Value** that starts with 10,000 and increments for each option you add.  
  
   Edit the **Label** to be the text you want to display.  
  
   You can edit the **Value**, but we recommend that you accept the auto-generated value. The value must be unique within the options.  
  
   The **Description** for each option is not visible to people using the application. Use it to provide some definition of the category it represents so that others editing this option set in the future can understand your intention in adding it.
 
###### Edit existing options  
- To edit an option that already exists you may change the **Label**, **Value** and **Description** values just as you would when creating a new option. 

###### Delete an option  
- To delete an option you select one and choose the delete icon.  
  
  > [!IMPORTANT]
  > If you delete an option that has already been used in entity records, the data value in those records will be invalid. If you are not sure, use Advanced Find to see if there are any records set to the value you are about to delete. If they are set to the option you plan to delete, you should change the data before you delete the option. After you delete the option you will no longer be able to use Advanced Find to query records that have that option set.
 
###### Change the order used by options  
- Use the green arrows in options toolbar to move selected options up or down.  
  
  Use the ascending or descending sort buttons to sort all options in the respective direction according to their label values.  
  
<a name="BKMK_UsingGlobalOptionSets"></a>   
## Use a global option set  
 To use a global option set, you create or edit a field in the field editor.  
  
1.  Choose **Customize the System**.  
 
2.  In the solution explorer, select an entity and then choose **Fields**.  
  
3.  Select the field you want to edit or select **New** to create a new field.  
  
4.  In the field editor, select **Yes** for **Use Existing Option Set**.  
  
     If you are creating a new field you need to first select **Option Set** for the **Data Type**.  
  
5.  Make a selection in the **Option Set** drop-down menu.  
  
6.  When you have completed your entries, select **Save and Close**.  
  
> [!NOTE]
>  You can also get to the field editor through Forms. Select an entity and then choose **Forms**. Select a field and then choose **Change Properties**. In the dialog box select the **Details** tab and then choose **Edit**.  
  
 In addition to the option sets you see in the solution explorer, there are also a number of system global option sets. You can use these if they happen to meet your need but they aren’t customizable.  
  
> [!NOTE]
>  The system global option set options may change with updates or new versions so we recommend you don’t use them unless you are certain that your requirements align with the way that the application uses these values.  
  
 In addition to selecting the global option set, you can also choose which of the options (if any) should be the **Default Value** for that field.  
  
### See also  
 [Entities and metadata overview](../customize/create-edit-metadata.md)   
 [Create and edit entities](../customize/create-edit-entities.md)   
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md) <br/>
 [Create and edit fields](../customize/create-edit-fields.md)   
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]