---
title: "Create and manage Word templates in Dynamics 365 Sales | MicrosoftDocs"
description: "Create templates in Dynamics 365 Sales so all documents that go out to your customers have a consistent look per your organization’s branding guidelines."
ms.date: 06/24/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
---

# Create and manage Word templates

Microsoft Word provides powerful ways to present your Dynamics 365 Sales data in a standardized and well-formatted document. Use Word templates to ensure that all the documents that go out to your customers have a consistent look per your organization’s branding. You can easily create and share your template with others.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager, Sales Professional Manager, or Vice President of Sales <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Create a Word template

Templates help users to generate standardized documents with Dynamics 365 Sales data.

Depending on the license you have, select one of the following tabs to know on how to create word templates for Dynamics 365:

# [Sales Premium and Sales Enterprise](#tab/SE)

1. From the Sales Hub app, select the **Settings** icon (:::image type="content" source="media/settings-icon.png" alt-text="Settings icon":::), and then **Advanced settings**. 

2. Follow the instructions in [Use Word templates to create standardized documents](/power-platform/admin/using-word-templates-dynamics-365?context=/dynamics365/context/sales-context) to create a word template.

# [Sales Professional](#tab/SP)

Follow the steps in this article to successfully create Word templates in Dynamics 365 Sales Professional.

### Step 1: Create a Word template

1.  Make sure you have the System Administrator role in Dynamics 365 Sales Professional.

2.  In the site map, select **Sales Settings**.

3.  Under **Advanced Settings**, select **Excel and Word Templates**.

4.  Select **New template**.

5.  In the **Create Template Type** pane, select **Word template**, and then select **Next**.

6.  In the **Select Entity** pane, select the entity to which the template applies. The template uses data from this entity.

    :::image type="content" source="media/select-entity-create-template-wizard.png" alt-text="Select entity in the Create Template wizard":::

7.  To add the fields that you want to be included in the Word template, select **Choose Related Entities**. The **Settings Overview** dialog box opens.

    The relationships you select on this screen determine which entities and fields are available later, when you define the Word template. Select only the relationships you need to add Dynamics 365 Sales Professional data to the Word template. When you’re done, select **Done**.

    Here are some example relationships for the Account entity:

    -   1:N Relationship. An account can have multiple contacts.

    -   N:1 Relationship. A lead, account, or contact can have multiple accounts.

    -   N:N Relationship. An account can have multiple marketing lists. A marketing list can have multiple accounts.

     > [!NOTE] 
     > To ensure documents download in a timely matter, there is an upper limit of 100 for the number of related records returned for each relationship. For example, if you’re exporting a template for an account, and you want to include a list of its contacts, the document will return at most 100 of the account’s contacts.

8.  In the **Select Entity** pane, select **Next**.

9.  In the **Download Template** pane, select **Download File** to create a Word file on your local computer with the exported entity included as XML data.

10.  To upload the template later, select  the **Upload the template later** check box, and then select **Done**.

11.  To upload the template after you customize the data, go to the list of templates, and then select **Upload template**. For more information, see the [Step 4: Upload the Word template back into the Sales app](#step-4-upload-the-word-template-back-into-the-sales-app).

### Step 2: Enable the Developer tab

Open the Word template file. At this point, the document appears to be blank.

To see and add Dynamics 365 Sales Professional XML data, you need to enable the Word Developer tab.

1.  Go to **File** \> **Options** \> **Customize Ribbon**, and then select the **Developer** check box.

    :::image type="content" source="media/enable-developer-tab.png" alt-text="Enable Developer tab in Word":::

2.  Select **OK**.

    The **Developer** tab now appears in the Word ribbon.


### Step 3: Define the Word template

Use the **XML Mapping** pane to define the Word template with Dynamics 365 Sales Professional entity fields.

1.  In your Word template, go to the **Developer** tab and select **XML Mapping Pane**.

    :::image type="content" source="media/xml-mapping-developer-tab.png" alt-text="XML Mapping Pane in the Developer tab of Word":::

    The default XML schema is selected.

2.  In the **Custom XML Part** list, select the Dynamics 365 Sales Professional XML schema. It begins with `urn:microsoft-crm/document-template/`.

    :::image type="content" source="media/select-schema-sales-professional.png" alt-text="Select the schema for Dynamics 365 Sales Professional":::

    > [!IMPORTANT]
    > If you have frequent accidental edits that cause Word to freeze or have performance degradation, be sure to turn off the AutoCorrect options according to the section: “A known issue and how to avoid it”.

3.  Expand the entity to see all available fields, right-click the field you wish to add, and then select **Insert Content Control** \> **Plain Text**.

    :::image type="content" source="media/insert-content-as-plain-text.png" alt-text="Insert content as Plain Text":::

    The field from Dynamics 365 Sales Professional is added to the Word template.

    Add other entity fields, add descriptive labels and text, and format the document.

    A completed template might look like this:

    :::image type="content" source="media/complete-word-template.png" alt-text="Complete Word template":::

    Some content control fields you entered likely have multiple lines of data. For example, accounts have more than one contact. To include all the data in your Word template, set the content control field to repeat.

#### Set content control fields to repeat

1.  Put fields with repeating data in a table row.

2.  Select the entire table row in the template.

    :::image type="content" source="media/row-selected-table.png" alt-text="Row selected in a table":::

3.  In the **XML Mapping** pane, right-click the relationship containing the content control fields, and then select **Repeating**.

    :::image type="content" source="media/set-content-control-fields.png" alt-text="Set the content control fields to repeat in Word template":::

When you use the Word template in Dynamics 365 Sales Professional to create a document, the table populates with multiple rows of data.

When the template has the fields and formatting you want, save it, and upload it into Dynamics 365 Sales Professional.

### Step 4: Upload the Word template back into the Sales app

When you have your Word template built the way you want, save it so you can upload it into Dynamics 365 Sales Professional.

An administrator can use the **Advanced Settings** page to upload the Word template into Dynamics 365 Sales Professional.

> [!NOTE]
> Users in your organization can see the templates available to them by selecting the **Word Templates** button on the command bar in the list of records.

1. In the site map, select **Sales Settings**.

1. Under **Advanced Settings**, select **Excel and Word Templates**.

1.  Select **Upload Template**.

1.  In the **Upload Template** pane, select **Choose File**. Find and select the file to be uploaded.

    :::image type="content" source="media/upload-template-step-create-template-wizard.png" alt-text="Upload Template step of Create Template wizard":::

1.  Select **Upload**.

1. In the **Summary** pane, review the file you're uploading, and then select **Finish**.

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Export sales records to PDF](create-quote-pdf.md)
- [Enable automatic generation of quote and invoice documents in Sales Professional](enable-automatic-generation-quotes-invoices.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
