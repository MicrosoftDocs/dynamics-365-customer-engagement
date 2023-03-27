---
title: "Create and deploy Word templates (Dynamics 365 Marketing) | Microsoft Docs"
description: "Create Word templates that you can use to export, format, and share detailed data from single records in Dynamics 365 Marketing."
ms.date: 10/25/2021
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Manage Word templates

Microsoft Word provides powerful ways to present your Dynamics 365 data in a standardized and well-formatted document. With Word templates, you can easily create and share your template with others, so all the documents that go out to your customers have a consistent look that matches your organization's branding.

When the templates are ready, users can generate standardized documents that are automatically populated with Dynamics 365 data with just one click.

## Step 1: Create a Word template

1. Sign in to Dynamics 365 as a user with the System Administrator role.

1. Open the **Settings** menu ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**.

1. The advanced settings area opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator. Navigate to **Settings** > **Business** > **Templates**.

1. On the next screen, select **Document Templates**, then choose **+ New** in the top ribbon.

1. Select **Word Template**, and then select an entity to which the template applies. The template will use data from this entity.

    > [!div class="mx-imgBorder"]
    > ![Choose a Word template.](media/create-template-type3.png "Choose a Word template")

1. To select the fields that you want to be included in the Word template, select **Select Entity**.

1. The **Select Entity** dialog box opens. The relationships you select on this screen determine what entities and fields are available later when you define the Word template. Only select the relationships you need to add Dynamics 365 data to the Word template. Here are some example relationships for the account entity:

   - 1:N Relationship. An account can have multiple contacts.
   - N:1 Relationship. A lead, account, or contact can have multiple accounts.
   - N:N Relationship. An account can have multiple marketing lists. A marketing list can have multiple accounts.

    When you're done choosing relationships, select **Download Template**. This will create a Word file on your local computer with the exported entity included as XML data.

     > [!NOTE]
     > To ensure that documents are downloaded in a timely matter, there is an upper limit of 100 for the number of related records returned for each relationship. For example, if you're exporting a template for an account and you want to include a list of its contacts, the document will return at most 100 of the account's contacts.

1. To upload the template after you customize the data, go to the list of templates, and then select **Upload Template**. More information: [Step 4: Upload the Word template back into Dynamics 365](#step-4-upload-the-word-template-back-into-dynamics-365)

## Step 2: Enable the Developer tab

Open the Word template file. At this point, the document appears to be blank.

![A new Word template.](media/word-blank.png "A new Word template")

To see and add Dynamics 365 XML data, you need to enable the **Word Developer** tab.

1. Go to **File** > **Options** > **Customize Ribbon**, and then select the **Developer** check box.

    ![The Customize Ribbon dialog in Word.](media/word-custom-ribbon-ill.png "Add the Developer tab to your ribbon in Word")

1. Select **OK**.

The **Developer** tab now appears in the Word ribbon.

![The Developer tab added to the Word ribbon.](media/word-developer-tab-ill.png "The Developer tab added to the Word ribbon")

## Step 3: Define the Word template

Use the **XML Mapping Pane** to define the Word template by using Dynamics 365 entity fields.

1. In your Word template, select **Developer** > **XML Mapping Pane**.

    ![The XML Mapping Pane button on the Developer tab.](media/word-XML-mapping-ribbon-ill.png "The XML Mapping Pane button on the Developer tab")

    The **XML Mapping** pane opens with the default XML schema selected.

    ![The XML Mapping pane in Word.](media/word-XML-mapping-pane.png "The XML Mapping pane in Word")

2. Select the Dynamics 365 XML schema. It will begin with "urn:microsoft-crm/document-template/".

    ![Select the Dynamics 365 XML schema.](media/ill-word-d365-schema.png "Select the Dynamics 365 XML schema")

   > [!IMPORTANT]
   > If you have frequent accidental edits that cause Word to freeze or degrade its performance, turn off the AutoCorrect options.

3. Expand the entity to see all available fields, right-click the field you want to add, and then select **Insert Content Control** > **Plain Text**.

    ![Insert Content Control menu.](media/ill-word-add-field.png "Select a field to add as plain text")

    The field from Dynamics 365 is added to the Word template.

    ![A Word template with one field added.](media/word-field-added.png "A Word template with one field added")

4. Add additional entity fields, add descriptive labels and text, and format the document. A completed template might look like this:

    ![An example of a completed Word template.](media/word-template-example.png "An example of a completed Word template")

5. Some content control fields you entered are likely to have multiple lines of data. For example, accounts have more than one contact. To include all the data in your Word template, set the content control field to repeat as follows:

   1. Put fields with repeating data in a table row.

   2. Select the entire table row in the template.

       ![A table in Word with a full row selected.](media/word-template-row.png "A table in Word with a full row selected")

   3. In the **XML Mapping** pane, right-click the relationship containing the content control fields, and then select **Repeating**.

       ![Set a field to repeating in the XML Mapping pane.](media/word-template-repeating.png "Set a field to repeating in the XML Mapping pane")

      When you use the Word template in Dynamics 365 to create a document, the table will be populated with multiple rows of data.

6. When the template has the fields and formatting you want, save it and upload it into Dynamics 365.

<a name="step-4-upload-the-word-template-back-into-dynamics-365"></a>

## Step 4: Upload the Word template into Dynamics 365

When you have your Word template built the way you want, save it so you can upload it into Dynamics 365.

An administrator can use the **Settings** page to upload the Word template into Dynamics 365.

> [!NOTE]
> Users in your organization can see the templates available to them by selecting **Word Templates** on the command bar in the list of records.

1. Open the **Settings** menu ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**.

1. Navigate to **Settings** > **Business** > **Templates**.

1. On the next screen, select **Document Templates**, then choose **Upload Template** in the top ribbon.

1. Find and upload the file.

    > [!div class="mx-imgBorder"]
    > ![Upload Template dialog.](media/excel-upload-template2.png "Upload Template dialog")

1. Select **Upload**. You'll see the summary of the file you're uploading.

1. Select the **X** icon in the upper right of the top ribbon to close the information screen.

### See also

[Export data to Word or Excel docs](export-data-word-excel.md)  
[Data management settings](data-management-settings.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]