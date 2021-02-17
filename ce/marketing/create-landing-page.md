---
title: "Create a landing page (Dynamics 365 Marketing) | Microsoft Docs"
description: "A tutorial for how to create a new landing page that includes a form for Dynamics 365 Marketing."
ms.date: 10/29/2019
ms.service: dynamics-365-marketing
ms.custom: 
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

# Create a landing page with a form

A *landing page* is a webpage that functions as a customer touchpoint for one of your marketing initiatives. For example, you might send out an email message that invites recipients to sign up for a free white paper download. To get the download, message recipients must select a link that opens a webpage with a form where they enter information (which is saved directly in your Dynamics 365 Marketing database), and then they receive an email with the download link. The same landing page can also be made available to unknown visitors of your website, who will add themselves as new contacts in your database when they request the download.

In Dynamics 365 Marketing, a landing page is a type of *marketing page*. Other types of marketing pages include *subscription centers* and *forward-to-a-friend forms*, both of which support email marketing and are more specialized in purpose.

> [!NOTE]
> This tutorial describes how to create and publish a landing page when you are using a Power Apps portal to host your landing pages. However, Power Apps portals are an optional add-on for Dynamics 365 Marketing, so if you don't have a portal, then you must publish your landing pages and other interactive features for Dynamics 365 Marketing on your own webserver or CMS system. More information: [Create interactive features with or without portals](portals.md) and [Integrate Marketing with a CMS system or Power Apps portal](portal-optional.md)

To create a landing page and go live:

1. Most landing pages include an input form that people can use to submit information, so you'll start by creating the form itself. Go to **Marketing** > **Internet Marketing** > **Marketing Forms** and then select **New** on the command bar.

    ![Location of the New button](media/form-new-button-location.png "Location of the New button")


    > [!TIP]
    > Forms are standalone records, and each of them can be used on any number of marketing pages. In day-to-day work, you'll often reuse existing forms rather than create a new one for each landing page. But for this exercise, you'll create a new one.

1. The **New Marketing Form** page opens with the **Select a Form Template** dialog box shown. This is similar to the template dialog box presented for marketing emails (as you saw in [Create a marketing email and go live](create-marketing-email.md)). Choose a template, and then choose **Select**. The template dialog box closes, and your selected template is copied to your new form.

    ![Select a form template dialog](media/form-template-dialog.png "Select a Form Template dialog box")

1. Now you're looking at the form designer, which works like the email designer but provides different tools in the **Toolbox**. Start by selecting the **More header fields** button in the header to open a drop-down dialog and then make the following settings:

   - **Name**: This is an internal name for your form. This is the name you'll see when adding the form to a page or referencing it in a customer journey.
   - **Form Type**: Different types of marketing pages require different types of forms. You're making a landing page, so set this to **Landing Page**.
   - **Update Contacts/Leads**: Set this to **Contacts and Leads**. This means that Dynamics 365 Marketing looks for existing contacts and leads that match submissions from this form and will update any existing contacts and leads, or create new ones.

    ![Required fields for a new form](media/form-required-fields.png "Required fields for a new form")

1. Because we started with a template, the form already contains the fields we need, but we want the first name, last name, and email to be required (which means that contacts must supply values for these fields to submit the form). Each required field shows a red asterisk on the form. Select the **First Name** field to open the **Properties** panel for that field. Make sure the **Required** check box is selected. Consider also adding a reminder message (such as "First name is required") in the **Required error message** field. Note that the red asterisk now appears next to the **First Name** field label to mark it as a required field. Make sure that the first name, last name, and email fields are all marked as required.

    ![Mark a field as required](media/form-field-required.png "Mark a field as required")

1. Go back to the **Toolbox** tab and find the **Country** element under the **Fields** heading . Drag the **Country** element (or other available field) to your form, but don't make it required.

    ![Add a field to the form](media/form-add-field.png "Add a field to the form")

1. On the command bar, select **Check for Errors**, and then fix any problems that are reported just as you did with the email message and customer journey.

1. On the command bar, select **Save** to save your form and then select **Go Live** to make your form available for use on a marketing page.

1. Now you're ready to use your new form on a landing page. Go to **Marketing** > **Internet Marketing** > **Marketing Pages**, and then select **New** on the command bar. The **New Marketing Page** page opens with the **Select a Template** dialog box shown. Find and select a template that you like, but make sure the one you choose shows a **Type** of **Landing page**. Select the **Select** button to load your chosen template.

    ![Select a page template dialog](media/page-template-dialog.png "Select a Template dialog box")


9. The **Select a Template** dialog box closes, and the content from your selected template is copied to your design. As with the form designer, there are required fields at the top of the page. Open the drop-down dialog in the header and enter the following:

   - **Name**: Enter a name for the page that you can easily recognize later. This name is internal-only.
   - **Type**: Make sure this is set to **Landing page**.
   - **Partial URL**: When you publish the page, this value becomes part of its URL. The page will be published on your Power Apps portal, so the final URL for the page will have the form: **https://*&lt;YourOrg&gt;*.microsoftcrmportals.com/*&lt;PartialURL&gt;***. Enter a suitable partial URL (note that contacts might notice this text when they load your page).

    ![Required fields for a new page](media/page-required-fields.png "Required fields for a new page")

    You are now in the page designer, which resembles the form and email designers. Your page already includes lots of content that came from the template you chose, including placeholder images, sample text, and more. Most of these are placed by using standard **Toolbox** items like **Text** elements and **Image** elements, though some layout features are hard-coded in HTML as part of the template. As with email messages, you can add new design elements, edit text directly on the canvas, and configure design elements by selecting them and using the **Properties** tab. You can also set global page styles by using the **Styles** tab. In a real project, you would spend time now working with all these settings to create and style your content.

1. Most landing page templates already include an unconfigured **Form** element that shows a placeholder with the text **Select a form**. Find and select it on the page (or add a new **Form** element from the **Toolbox** tab if needed). The **Properties** tab opens when you select the **Form** element. Set the **Marketing Form** field to the name of the form that you created earlier in this procedure. Your form design is then loaded onto the page.

   ![Assign a form to a form element](media/page-block-assign-form.png "Assign a form to a form element")  

   > [!TIP]
    > Forms are imported by reference—they are not copied to your page. That means that if you go back and edit the form, any changes you make there will be seen on all existing pages that use that form, so be careful when editing forms!

1. As you did with the other items you created, select **Save** on the command bar. Then select **Check for Errors** and read the results in the notification area. Address any issues, and recheck until your design passes. Finally, choose **Go Live**. If the command is successful, your page will then be published and available on the internet.

1. Go to the **Summary** tab. Here you'll find information about your page, a **Timeline** where you can add notes and track its development, and links to various related records. You'll also find the **Full Page URL** in the **Content** section. Select the preview button ![The page preview button](media/page-preview-button.png "The page preview button") at the right side of the **Full Page URL** field to open the page. Then enter and submit some information through the page.

    ![Find the full page URL on the summary tab](media/page-summary-url.png "Find the full page URL on the summary tab")

    > [!TIP]
    > Many entities in Dynamics 365 Marketing have a **Summary** tab like this one, where you can see general settings, a timeline, and related records. For some entities, this page is called **General**.

    As people interact with your page, information will become available in the **Insights** tab of the page record, including lists of contacts who visited and submitted the form on the page and analytics about its performance. You should be able to see your test submission on the **Submissions** panel of the **Insights** tab. Similar insights are provided for form records.

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

### See also

[Design your digital content](design-digital-content.md)  
[Keyboard shortcuts and accessibility features for content designers](designer-shortcuts.md)  
[Design elements reference](content-blocks-reference.md)  
[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[How Dynamics 365 Marketing uses cookies](cookies.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]