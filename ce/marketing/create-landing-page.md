---
title: "Create a landing page in Dynamics 365 for Marketing | Microsoft Docs"
description: "A tutorial for how to create a new landing page that includes a form for Dynamics 365 for Marketing"
keywords: "tutorial; landing page; marketing page; form; page"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
	- Dynamics 365 (online)
	- Dynamics 365 Version 9.x
ms.date: 11/07/2017
ms.service: crm-online
ms.topic: get-started-article
ms.assetid: a8fe7492-44d8-4715-9815-19e1e01aafb5
ms.reviewer: renwe
---
# Create a landing page with a form

A *landing page* is a web page that functions as a customer touch point for one of your marketing initiatives. For example, you might send out an email message that invites recipients to sign up for a free whitepaper download. To get the download, message recipients must click a link that opens a web page with a form where they must enter some information (which goes straight into your [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] database), and then they will receive an email with the download link. The same landing page could also be available to unknown visitors of your website, who will add themselves as new contacts in your database while requesting the download.

In [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)], a landing page is a type of a *marketing page*. Other types of marketing pages include *subscription centers* and *forward-to-a-friend forms*, both of which support email marketing and are more specialized in purpose. All marketing pages run on your [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] server and are based on the [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] portals feature.

To create a landing page and go live:

1.  Most landing pages include an input from that people can use to submit information, so you’ll start by creating the form itself. Go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Internet [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Forms**.

> ![Location of the New button](media/form-new-button-location.png "Location of the New button")  
>
> Choose **New** from the command bar.

|                                                                                                                                                                                                                                                                                                                   |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ### **TIP:** Forms are stand-alone records, and each of them can be used on any number of marketing pages. In day-to-day work, you’ll often reuse existing forms rather than creating a new one for each landing page. But for this exercise, you’ll create a new one. |

1.  The **New [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Form** page opens with the **Select a Form Template** dialog also shown. This is similar to the template dialog presented for marketing emails (as you saw in [Create a marketing email and go live](create-marketing-email.md)).  

> ![Select a form template dialog](media/form-template-dialog.png "Select a form template dialog")  
>
> Find and select the **Newsletter subscription** template and then choose **Select**. The template selector closes, and your selected template is copied into your new form.

1.  Now you are looking at the form designer, which works like the email designer, but provides different tools in the **Toolbox**. As with the email designer, there are required fields at the top of the designer page.

> ![Required fields for a new form](media/from-required-fields.png "Required fields for a new form")  
>
> Enter the following:

- **Name**: this is an internal name for your form.

- **Form Type**: different types of marketing pages require different types of forms. You’re making a landing page, so set this to **Landing Page**.

- **Update Contacts/Leads**: set this to **Contacts and Leads**. This means that [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] will look for existing contacts and leads that match submissions from this form, and update them if found. Otherwise, it will create new contacts and leads.

1.  We want the form to include four fields (first name, last name, email, and country), and we want the first name, last name, and email to be required (which means that contacts must supply values for these fields to submit the form). Thanks to the template, we are almost there.

> ![Mark a field as required](media/form-field-required.png "Mark a field as required")  
>
> Each required field shows a red asterisk on the form. Select the **First Name** field on the canvas to open the **Details** tab for it. Make sure the **Required** check box is selected. Note that the red asterisk appears when the box is selected and goes away when it’s cleared. Make sure that the first name, last name, and email fields are all marked as required.

1.  Go back to the **Toolbox** tab and find the **Country** block under the **Fields** heading. Drag the **Country** block to your form but don’t make it mandatory.

> ![Add a field to the form](media/form-add-field.png "Add a field to the form")  

1.  Choose **Check for Errors** from the command bar and fix any problems that are reported, just as you did with the email message and customer journey.

2.  Choose **Save** from the command bar to save your form. Forms are always live, so you don’t need the **Go Live** button.

3.  Now you’re ready to use your new form on a landing page. Go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Lead Management &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Pages** and choose **New** from the command bar. The **New [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Page** page opens with the **Select a Template** dialog shown.

> ![Select a page template dialog](media/page-template-dialog.png "Select a page template dialog")  
>
> It’s important to choose a template of the right type (landing page), so do the following here:

1.  Go to the **Type** tab.

2.  Choose **Landing Page** from the drop-down list.

3.  Browse the available templates and select one that appeals to you.

4.  Choose **Select**.

<!-- -->

1.  The **Select a Template** dialog closes and the content from your selected template is copied into your design. As with the form designer, there are required fields at the top of the designer page.

> ![Required fields for a new page](media/page-required-fields.png "Required fields for a new page")  
>
> Enter the following:

- **Name**: this is an internal name for your page. Enter any name that you will easily recognize later.

- **Type**: make sure this is set to **Landing page**.

- **Partial URL**: when you publish the page, this value becomes part of its URL. The page will be published on your [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] portal server, so the final URL for the page will have the form: **https://*&lt;YourOrg&gt;*.microsoftcrmportals.com/*&lt;PartialURL&gt;***. Enter a suitable partial URL (note that contacts might notice this text when they load your page).

> You are now in the page designer, which resembles the form and email designers. Your page already includes lots of content that came from the template you chose, including placeholder images, sample text, and more. Most of these are placed using standard **Toolbox** items like **Text** blocks and **Image** blocks, though some layout features are hard-coded in HTML as part of the template. As with email messages, you can add new blocks, edit text directly on the canvas, and configure blocks by selecting them and using the **Details** tab. You can also set global page styles using the **Styles** tab. In a real project, you would spend time now working with all these settings to create and style your content.

1.  Most landing page templates already include an unconfigured **Form** block that shows a placeholder with the text **Select a form**. Find and select it on the page (or add a new **Form** block from the **Toolbox** tab if needed).

> ![Assign a form to a form block](media/page-block-assign-form.png "Assign a form to a form block")  
>
> The **Details** tab opens when you select the **Form** block. Set the **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Form** field to the name of the form that you created earlier in this procedure. Your form design loads onto the page.

|                                                                                                                                                                                                                                                    |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** Forms are imported by reference—they are not copied onto your page. That means that if you go back and edit the form, any changes you make there will be seen on all existing pages that use that form, so be careful when editing forms! |

1.  As you did with the other items you created, choose **Save** from the command bar. Then **Check for Errors** and read the results in the notification area. Address any issues and recheck until your design passes. Finally, choose **Go Live**. On success, your page is published and available on the internet.

2.  Go to the **Summary** tab.

> ![Find the full page URL on the summary tab](media/page-summary-url.png "Find the full page URL on the summary tab")  
>
> Here you’ll find information about your page, a **Timeline** where you can add notes and track its development, and links to various related records. You’ll also find the **Full Page URL** in the **Content** section. Click on the preview button ![The page preview button](media/page-preview-button.png "The page preview button") at the right side of the **Full Page URL** field to open the page. Then enter and submit some information through the page.  

|                                                                                                                                                                    |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** Many entities in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] feature a **Summary** tab like this one, where you can see general settings, a timeline, and related records. |

1.  Switch to the **[!INCLUDE[pn-insights](../includes/pn-insights.md)]** view using the drop-down list above the page name headline.

> ![Location of the view selector](media/page-view-selector.png "Location of the view selector")  
>
> As people interact with your page, information will become available in the **[!INCLUDE[pn-insights](../includes/pn-insights.md)]** view, including lists of contacts who visited and submitted the page and analytics about its performance. You should be able to see your test submission on the **Submissions** tab here.

