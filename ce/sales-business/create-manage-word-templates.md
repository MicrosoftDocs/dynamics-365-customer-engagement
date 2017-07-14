---
title: "Manage Word templates in Dynamics 365 for Sales, Business edition | Microsoft Docs"
description: "Create Word templates in Dynamics 365 for Sales, Business edition to help your users send out standardized and well formatted Sales data to customers. "
keywords: "Word template, Standardized data; Consistent look"
author: shubhadaj
ms.author: shujoshi
manager: sakudes
applies_to: "Dynamics 365 (online)"
ms.date: 07/14/2017
ms.service: dynamics-365
ms.topic: article
ms.assetid: de087792-7fd4-4cd7-97bc-f19cf4920f8c
ms.reviewer: 
---
# Manage Word templates in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)], Business edition

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Word provides powerful ways to present your [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] data in a standardized and well formatted document. With Word templates, you can easily create and share your template with others, so all the documents that go out to your customer have a consistent look as per your organization’s branding.

When the templates are ready, users can generate standardized documents automatically populated with [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] data with just one click.

Follow the steps in this topic to successfully create Word templates in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

### Step 1: Create a Word template

1.  ### Make sure you have the System Administrator role in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

2.  Go to **Advanced** **Settings** &gt; **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] and Word Templates** &gt; **New** **Template**. You must have a System Administrator or System Customizer role to be able to access the Advanced Settings page.

3.  Select **Word Template**, and then click **Next**.

[Select template type in the Create Template wizard](media/create-template-wizard-select-template-type.png "Select template type in the Create Template wizard")  

4.  Select an entity to which the template applies. The template will use data from this entity.

![Select entity in the Create Template wizard](media/create-word-template-wizard-select-entity.png "Select entity in the Create Template wizard")  

5. To select the fields that you want to be included in the Word template, click **Choose Related Entities**. The **Choose Related Entity** dialog box opens.

The relationships you select on this screen determine what entities and fields are available later when you define the Word template. Only select the relationships you need to add [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] data to the Word template. When you’re done selecting, click **Done**.

Here are some example relationships for the Account entity.

-   1:N Relationship. An account can have multiple contacts.

-   N:1 Relationship. A lead, account, or contact can have multiple accounts.

-   N:N Relationship. An account can have multiple marketing lists. A marketing list can have multiple accounts.

>[!Note]
> To ensure documents download in a timely matter, there is an upper limit of 100 for the number of related records returned for each relationship. For example, if you’re exporting a template for an account, and you want to include a list of its contacts, the document will return at most 100 of the account’s contacts.

1.  In the **Select Entity** dialog box, click **Next**.
2.  Click **Download** to create a Word file on your local computer with the exported entity included as XML data.
3.  To upload the template later, select **Upload the template later** check box, and then click **Next**.
4.  To upload the template back after you customize the data, go to the list of templates, and then click **Upload Template**. 

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Upload the template back into [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]](#BKMK_Upload)  

### Step 2: Enable the Developer tab

Open the Word template file. At this point, the document appears to be blank.

![Blank Word template](media/blank-word-template.png "Blank Word template")  

To see and add [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] XML data, you need to enable the Word Developer tab.

1.  Go to **File** &gt; **Options** &gt; **Customize Ribbon**, and then select the **Developer** check box.

> ![Enable Developer tab in Word](media/enable-developer-tab.png "Enable Developer tab in Word")  

2.  Click **OK**.

The **Developer** tab now appears in the Word ribbon.

![Developer tab in Word](media/developer-tab-in-Word.png "Developer tab in Word")  

### Step 3: Define the Word template

Use the XML Mapping Pane to define the Word template with [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] entity fields.

1.  In your Word template, click **Developer** &gt; **XML Mapping Pane**.

> ![XML Mapping Pane in the Developer tab of Word](media/xml-mapping-pane-in-develoer-tab.png "XML Mapping Pane in the Developer tab of Word")  
>
> The default XML schema is selected.
>
> ![Default XML schema selected in XML Mapping Pane](media/xml-schema-selected.png "Default XML schema selected in XML Mapping Pane")  

1.  Select the [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] XML schema. It will begin with “urn:microsoft-crm/document-template/”.

> ![Select the schema for [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]](media/select-dynamics-365-sales-schema.png "Select the schema for [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]")  
>
> **Important **
>
> If you have frequent accidental edits that cause Word to freeze or have performance degradation, be sure to turn off the AutoCorrect options according to the section: “A known issue and how to avoid it”.

1.  Expand the entity to see all available fields, right-click the field you wish to add, and then click **Insert Content Control** &gt; **Plain Text**.

> ![Insert content as Plain Text](media/insert-content-control.png "Insert content as Plain Text")  

The field from [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] is added to the Word template.

![Field added to Word doc](media/field-added-to-Word.png "Field added to Word doc")  

Add additional entity fields, add descriptive labels and text, and format the document.

A completed template might look like this:

![Complete Word template](media/complete-word-template.png "Complete Word template")  

Some content control fields you entered likely have multiple lines of data. For example, accounts have more than one contact. To include all the data in your Word template, set the content control field to repeat.

Set content control fields to repeat

1.  Put fields with repeating data in a table row.

2.  Select the entire table row in the template.

> ![Row selected in a table](media/select-entire-row.png "Row selected in a table")  

1.  In the XML Mapping Pane, right-click the relationship containing the content control fields, and then click **Repeating**.

> ![Set the content control fields to repeat in Word template](media/repeat-content-control-fields.png "Set the content control fields to repeat in Word template")  

When you use the Word template in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] to create a document, the table will populate with multiple rows of data.

When the template has the fields and formatting you want, save it and upload it into [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

### Step 4: Upload the Word template back into [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]

When you have your Word template built the way you want, save it so you can upload it into [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

An administrator can use the Advanced Settings page to upload the Word template into [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

**Note:**

Users in your organization can see the templates available to them by clicking the **Word Templates** button on the command bar in the list of records.

1.  In the Sales app, go to **Advanced** **Settings** &gt; **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)]** **and Word** **Templates**.

2.  Click **Upload Template**.

3.  Find and upload the file.

> ![create-template-wizard-step-upload-template](media/create-template-wizard-step-upload-template.png "")  

1.  Click **Upload**.

> You’ll see the summary of the file you’re uploading.

1.  Click **Finish**.

