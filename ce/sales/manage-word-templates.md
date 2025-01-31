---
title: "Create and manage Word templates in Dynamics 365 Sales | MicrosoftDocs"
description: "Create templates in Dynamics 365 Sales so all documents that go out to your customers have a consistent look per your organization’s branding guidelines."
ms.date: 01/28/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
---

# Create and manage Word templates

Microsoft Word provides powerful ways to present your Dynamics 365 Sales data in a standardized and well-formatted document. Use Word templates to ensure that all the documents that go out to your customers have a consistent look per your organization’s branding. You can easily create and share your template with others.

## Create a Word template

Templates help users to generate standardized documents with Dynamics 365 Sales data.

Depending on the license you have, select one of the following tabs to know on how to create word templates for Dynamics 365:

# [Sales Premium and Sales Enterprise](#tab/SE)

Follow the instructions in [Use Word templates to create standardized documents](/power-platform/admin/using-word-templates-dynamics-365?context=/dynamics365/context/sales-context) to create a word template.

# [Sales Professional](#tab/SP)

Follow the steps in this article to successfully create Word templates in Dynamics 365 Sales Professional.

### Step 1: Create a Word template

1.  Make sure you have the System Administrator role in Dynamics 365 Sales Professional.

2.  In the site map, select **Sales Settings**.

3.  Under **Advanced Settings**, select **Excel and Word Templates**.

4.  Select **New template**.

5.  In the **Create Template Type** pane, select **Word template**, and then select **Next**.

    :::image type="content" source="media/select-template-type-create-template-wizard.png" alt-text="Select template type in the Create Template wizard.":::

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

Follow the instructions in [Step 2: Enable the Developer tab](/power-platform/admin/using-word-templates-dynamics-365?context=/dynamics365/context/sales-context#step-2-enable-the-developer-tab) to enable the Developer tab in Word.

### Step 3: Define the Word template

Follow the instructions in [Step 3: Define the Word template](/power-platform/admin/using-word-templates-dynamics-365?context=/dynamics365/context/sales-context#step-3-define-the--template) to define the Word template.

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

## Related information

- [Export sales records to PDF](create-quote-pdf.md)
- [Enable automatic generation of quote and invoice documents in Sales Professional](enable-automatic-generation-quotes-invoices.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]

