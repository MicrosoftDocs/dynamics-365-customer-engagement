---
title: "Create a landing page (Dynamics 365 for Marketing) | Microsoft Docs"
description: "A tutorial for how to create a new landing page that includes a form for Dynamics 365 for Marketing"
keywords: tutorial; landing page; marketing page; form; page
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: a8fe7492-44d8-4715-9815-19e1e01aafb5
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create a landing page with a form

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A *landing page* is a webpage that functions as a customer touchpoint for one of your marketing initiatives. For example, you might send out an email message that invites recipients to sign up for a free white paper download. To get the download, message recipients must select a link that opens a webpage with a form where they enter information (which is saved directly in your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database), and then they receive an email with the download link. The same landing page can also be made available to unknown visitors of your website, who will add themselves as new contacts in your database when they request the download.

In [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], a landing page is a type of *marketing page*. Other types of marketing pages include *subscription centers* and *forward-to-a-friend forms*, both of which support email marketing and are more specialized in purpose. All marketing pages run on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] server and are based on the portals feature.

To create a landing page and go live:

1. Most landing pages include an input form that people can use to submit information, so you'll start by creating the form itself. Go to **Marketing** &gt; **Internet Marketing** &gt; **Marketing Forms**.  
    ![Location of the New button](media/form-new-button-location.png "Location of the New button")

    On the command bar, select **New**.

    > [!TIP]
    > Forms are standalone records, and each of them can be used on any number of marketing pages. In day-to-day work, you'll often reuse existing forms rather than create a new one for each landing page. But for this exercise, you'll create a new one.

2. The **New Marketing Form** page opens with the **Select a Form Template** dialog box shown. This is similar to the template dialog box presented for marketing emails (as you saw in [Create a marketing email and go live](create-marketing-email.md)).  
    ![Select a form template dialog](media/form-template-dialog.png "Select a Form Template dialog box")

    Choose a template, and then choose **Select**. The template dialog box closes, and your selected template is copied to your new form.

3. Now you are looking at the form designer, which works like the email designer but provides different tools in the **Toolbox**. As with the email designer, there are required fields at the top of the page.  
    ![Required fields for a new form](media/from-required-fields.png "Required fields for a new form")

    Enter the following:
   - **Name**: This is an internal name for your form.
   - **Form Type**: Different types of marketing pages require different types of forms. You're making a landing page, so set this to **Landing Page**.
   - **Update Contacts/Leads**: Set this to **Contacts and Leads**. This means that [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] looks for existing contacts and leads that match submissions from this form and will update any existing contacts and leads, or create new ones.

4. We want the form to include four fields (first name, last name, email, and country), and we want the first name, last name, and email to be required (which means that contacts must supply values for these fields to submit the form). Thanks to the template, we're almost there.  
    ![Mark a field as required](media/form-field-required.png "Mark a field as required")

    Each required field shows a red asterisk on the form. Select the **First Name** field on the canvas to open the **Properties** tab for it. Make sure the **Required** check box is selected. Note that the red asterisk appears when the box is selected and goes away when it's cleared. Make sure that the first name, last name, and email fields are all marked as required.

5. Go back to the **Toolbox** tab and find the **Country** element under the **Fields** heading. Drag the **Country** element to your form, but don't make it required.  
    ![Add a field to the form](media/form-add-field.png "Add a field to the form")

6. On the command bar, select **Check for Errors**, and then fix any problems that are reported just as you did with the email message and customer journey.

7. On the command bar, select **Save** to save your form. Forms are always live, so you don't need to select **Go Live**.

8. Now you're ready to use your new form on a landing page. Go to **Marketing** > **Internet Marketing** > **Marketing Pages**, and then select **New** on the command bar. The **New Marketing Page** page opens with the **Select a Template** dialog box shown.  
    ![Select a page template dialog](media/page-template-dialog.png "Select a Template dialog box")

    It's important to choose a template of the right type (landing page), so do the following here:
    1. Go to the **Type** tab.
    1. Choose **Landing Page** from the drop-down list.
    1. Browse the available templates and select one that appeals to you.
    1. Choose **Select**.

9. The **Select a Template** dialog box closes, and the content from your selected template is copied to your design. As with the form designer, there are required fields at the top of the page.  
    ![Required fields for a new page](media/page-required-fields.png "Required fields for a new page")

    Enter the following:
   - **Name**: Enter a name for the page that you can easily recognize later. This name is internal-only.
   - **Type**: Make sure this is set to **Landing page**.
   - **Partial URL**: When you publish the page, this value becomes part of its URL. The page will be published on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal server, so the final URL for the page will have the form: **https://*&lt;YourOrg&gt;*.microsoftcrmportals.com/*&lt;PartialURL&gt;***. Enter a suitable partial URL (note that contacts might notice this text when they load your page).

     You are now in the page designer, which resembles the form and email designers. Your page already includes lots of content that came from the template you chose, including placeholder images, sample text, and more. Most of these are placed by using standard **Toolbox** items like **Text** elements and **Image** elements, though some layout features are hard-coded in HTML as part of the template. As with email messages, you can add new design elements, edit text directly on the canvas, and configure design elements by selecting them and using the **Properties** tab. You can also set global page styles by using the **Styles** tab. In a real project, you would spend time now working with all these settings to create and style your content.

10. Most landing page templates already include an unconfigured **Form** element that shows a placeholder with the text **Select a form**. Find and select it on the page (or add a new **Form** element from the **Toolbox** tab if needed).  
     ![Assign a form to a form element](media/page-block-assign-form.png "Assign a form to a form element")  

     The **Properties** tab opens when you select the **Form** element. Set the **Marketing Form** field to the name of the form that you created earlier in this procedure. Your form design is loaded onto the page.

     > [!TIP]
     > Forms are imported by reference—they are not copied to your page. That means that if you go back and edit the form, any changes you make there will be seen on all existing pages that use that form, so be careful when editing forms!

11. As you did with the other items you created, select **Save** on the command bar. Then select **Check for Errors** and read the results in the notification area. Address any issues, and recheck until your design passes. Finally, choose **Go Live**. If the command is successful, your page will be published and available on the internet.

12. Go to the **Summary** tab.  
     ![Find the full page URL on the summary tab](media/page-summary-url.png "Find the full page URL on the summary tab")

     Here you'll find information about your page, a **Timeline** where you can add notes and track its development, and links to various related records. You'll also find the **Full Page URL** in the **Content** section. Select the preview button ![The page preview button](media/page-preview-button.png "The page preview button") at the right side of the **Full Page URL** field to open the page. Then enter and submit some information through the page.

    > [!TIP]
    > Many entities in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] have a **Summary** tab like this one, where you can see general settings, a timeline, and related records.

13. Switch to the **Marketing page: Insights** form view by using the drop-down list above the page name headline.  
     ![Location of the view selector](media/page-view-selector.png "Location of the view selector")

     As people interact with your page, information will become available in the **Marketing page: Insights** form view, including lists of contacts who visited and submitted the form on the page and analytics about its performance. You should be able to see your test submission on the **Submissions** tab here.

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

### See also

[Design your digital content](design-digital-content.md)  
[Keyboard shortcuts and accessibility features for content designers](designer-shortcuts.md)  
[Design elements reference](content-blocks-reference.md)  
[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[How Dynamics 365 for Marketing uses cookies](cookies.md)

