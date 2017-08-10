---
title: "Create and edit a Customer Service hub or Interactive Service hub card form in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2e41afce-b9e9-4c2f-b9bd-16e77b6430ab
caps.latest.revision: 7
ms.author: "anjgup"
manager: "sakudes"
---
# Create and edit a card form that presents a stream of data
In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], a card form is used to present data in a stream in the interactive dashboards.  
  
 For each entity that needs to be shown in the views or queues in the interactive dashboard streams, a card form must be created.  
  
 This card provides a template to show how the entity data will be presented in the stream.  
  
<a name="BKMK_CreateCardForm"></a>   
## Create a card form  
 You create forms using the form editor much like you create or edit other forms. Card forms are read only at runtime. Use them to create forms that are for reading purposes only.  
  
> [!NOTE]
>  All out-of-the-box entities that are enabled for the interactive experience already have an out-of-the-box card form created. You can change this default form, or you can create a new form if needed.  
  
1.  In the default solution, using the solution explorer, expand the **Entities** node, and then select the entity you want to create a new quick view form for.  
  
2.  Expand the entity, and then select the **Forms** node.  
  
3.  Click **New**, and then select **Card Form** to open the form editor.  
  
     The form has sections added to it by default. You can’t add sections to, or remove or move existing sections from the form.  
  
     The first section of the form is a color strip. A color strip can include any field that has a color definition associated with it, and is of the type Option Set. You can add only one field to this section.  
  
    > [!NOTE]
    >  You can only add four fields to the header, footer, and details through customization. However, you can add more fields through solution import. Regardless of the number of fields added to the header, footer, and details sections of the form, only the first four fields in each of the sections are displayed at runtime.  
  
4.  In the form editor, click **Form Properties** in the **Form** group of the **Home** tab.  
  
5.  In the **Form Properties** dialog box, enter a **Form Name** and **Description** to differentiate this card form from any others, and then close the **Form Properties** dialog box.  
  
6.  Edit the form to add the fields you want. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit a card form](../customize/create-edit-card-form.md#bkmk_EditCardForm)  
  
    > [!IMPORTANT]
    >  If you add a field and click **Field Requirement** > **Business Required** and then save it, you will not be able to delete the field.  
  
7.  To save the form and close the form editor, on the **Home** tab, **Save** group, click **Save and Close**.  
  
<a name="bkmk_EditCardForm"></a>   
## Edit a card form  
 Card forms have a simplified layout because they are designed to be viewed within a stream on a dashboard. One single-column tab is available. You can add fields or remove fields from the form.  
  
 When you edit a card form, you need to publish your changes before they will be visible in the application.  
  
> [!IMPORTANT]
>  After publishing the changes in the web application, the configuration changes must be downloaded in the Customer Service hub or Interactive Service hub before they are visible in the application.  
  
### See also  
 [Create and design interactive forms](../customize/create-design-interactive-forms-interactive-service-hub.md)   
 [Main interaction-centric form presentations](../customize/use-the-main-interactive-experience-form-and-its-components.md)
