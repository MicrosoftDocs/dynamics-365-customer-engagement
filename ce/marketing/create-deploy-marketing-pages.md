---
title: "Design, check, and publish marketing pages (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to design and deploy landing, forwarding, and subscription pages in Dynamics 365 for Marketing"
keywords: "landing page; subscription center; forward to a friend; form; field; matching"
ms.date: 09/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: a05ddbad-a57a-403a-aee9-2e91e2f5161f
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

# Create and deploy marketing pages

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A marketing page is a webpage that is hosted by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and usually includes a form where people can register for an offer, update their contact information, manage mailing list subscriptions, and more. All the information submitted through a marketing page is automatically captured by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and applied immediately to your customer database.

Marketing pages integrate with&mdash;and provide expanded functionality for&mdash;many other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] features, including email marketing, customer journeys, behavior analysis, lead scoring, and result analytics.

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

## Overview: How to create a new marketing page and go live

The overall process of creating a new marketing page and making it available on the web goes through the following stages:

1. Go to **Lead Management** &gt; **Marketing Pages**, and select **New** in the command bar to start creating a new page.

2. Choose a page template, which creates your initial design by establishing the page type, column layout, and sample content.

3. Add and edit your page content. Use the graphical editor to drag new page elements to your design (including forms, text, images, and more), and use the HTML editor to add extra features, custom styles, and scripts. Along the way, you might need to create new forms, but usually you'll be able to use existing ones.

4. When you are satisfied with the design, check it for required content and technical errors by selecting **Check for Errors** in the command bar. If a problem is found, read the description, address the issue, and try again until the page passes the error check.

5. Select **Save** in the command bar. Your page is now verified and saved in your system, but is still not available on the web. Select **Go Live** to publish it by using the portal capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], where it will be made available at a public URL. You are now ready to start promoting it by including links to it in your marketing email messages, banners, social-media posts, and other marketing initiatives.

The remainder of this topic provides more information about these steps, including how to work with forms and form fields, how to integrate marketing pages into emails and customer journeys, and how to read and interpret results.

## Types of marketing pages

There are three basic types of marketing pages:

- **Landing pages**  
    Landing pages provide a webpage with an input form that visitors can use to sign up for a download, discount, mailing list, or other perk by entering their contact details. When a visitor submits a form, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] automatically stores the submitted values in your database, creating new records or updating existing ones as needed.
- **Subscription centers**  
    All marketing email messages must include a link to a subscription center, where mail recipients can go to unsubscribe, choose other lists to subscribe to, or update their contact information. You can choose which mailing lists to include in each subscription center, but all subscription centers will also include a check box the visitor can use to opt out of all marketing emails.
- **Forward to a friend**  
    If you'd like to enable recipients of your marketing email messages to forward those messages to friends who might also be interested in your offers, create a forward-to-a-friend marketing page and include links to it in your marketing email messages. By encouraging contacts to use the forwarding form rather than forward a message by using their email client, you'll improve the accuracy of your email analytics. Forward-to-a-friend recipients won't see any personalized information that was intended for the original recipient. For reasons of data privacy, all data entered into a forward-to-a-friend form is deleted after 30 days, so no new contact or lead records are created unless a recipient of the forward chooses to register with your organization using a landing page.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] also includes both Voice of the Customer (for running online surveys) and Event Management (which includes a full-featured event portal that provides event information and registration). Like marketing pages, these provide interactive webpages that run as [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals, and work similarly to marketing pages under the hood, but they are more specialized so you'll work with them differently in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up the event portal](set-up-event-portal.md), and [Create and run online surveys](surveys.md)

## Create, view, and manage marketing pages

### Create a new marketing page

To create a new marketing page, do one of the following:

- Go to **Marketing** &gt; **Lead Management** &gt; **Marketing Pages** to go to the full list of all pages currently available on your site, and then select **+New** in the command bar. You'll first be asked to choose a template, which establishes the page type and column layout and might also provide sample content. Then you'll be in the content designer, where you can start designing your page.

- While working in a marketing email message or customer journey, add a marketing page tile or design element to your journey or message, and then select **+New** on the **Properties** tab instead of choosing an existing page. A quick-create flyout slides in from the side of the screen, where you must enter values for all required fields and then select **OK**. A new marketing page is created with your selected settings and is applied to your new customer-journey tile. However, you'll still need to finish the page later by choosing a template and customizing it as needed. You can do that now by selecting **Edit** on the **Properties** tab while the page is selected, or you can do it later either from here, or from the full list at **Marketing** &gt; **Lead Management** &gt; **Marketing Pages**.

### Design your content

After choosing a template, you'll be in the page content designer, which resembles the other digital content designers provided in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Work with it as follows:

- The **Content** &gt; **Designer** tab provides a graphical tool that you use to design your content by using drag-and-drop, point-and-click operations. Add new elements to your design by dragging elements from the **Content** &gt; **Designer** &gt; **Toolbox** tab to the content canvas. Choose a design element that already exists in your design, and then use the **Content** &gt; **Designer** &gt; **Properties** tab to configure and style it.

- When you select a design element on the canvas, you'll usually see a pop-up toolbar just above the element. The tools it offers vary depending on which type of design element you've selected. The toolbar typically provides commands to move, copy, or delete the selected element. For text elements, the toolbar offers commands for applying basic text formatting as you would in [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)].

- To style the overall page with basic fonts, colors, and background, open the **Content** &gt; **Designer** &gt; **Styles** tab.

- Use the **Designer** &gt; **HTML** tab to edit the raw HTML directly. You might use this to paste in an existing HTML design, or to fine-tune the code in ways the graphical editor doesn't support (such as custom attributes or logic).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design your digital content](design-digital-content.md)

### Establish marketing page templates

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] comes with a collection of sample templates to help get you started quickly. You can also save your own templates, which you might do to establish your own visual identity and quickly create new pages that conform to it.

You can view, edit, and create all marketing page templates by going to **Marketing** &gt; **Lead Management** &gt; **Marketing Page Templates**. The process for creating a new template is similar to creating a new page, but you'll start from a blank slate rather than choose a template at the beginning.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with email, page, and form templates](email-templates.md)

## Deploy your marketing pages

While you are building a marketing page it remains in draft status, and is therefore editable in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] but is unavailable to customers on the internet. When your page is ready for use, you must publish it by selecting **Go Live**. Your design will be checked for errors and then, provided it passes, be published to your portal. If a problem is found, read the error message, address the issue, and try again.

You can edit a live page by selecting **Edit** in the command bar. While you are editing it, it remains available on the internet. After editing, select **Save** to go live with your changes. Your design will be checked for errors and then, provided it passes, your updates will be published.

> [!NOTE]
> Most marketing pages include an embedded form, which you must design and publish separately from the page. The imported form is validated together with the page when you publish it, so if an embedded form has been removed or changed so it is no longer valid, then you'll see a validation error when publishing or saving an edited page.

You can remove a live page from the internet by selecting **Stop** in the command bar.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Go live with publishable entities and track their status](go-live.md)

## Integrate landing pages with other marketing initiatives

To include a link to a landing page in a marketing email, you can either create a dynamic text link (in a text element) that references the page by using the assist-edit feature, or add a dedicated marketing-page element, which creates a colorful call-to-action button that links to the page. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add dynamic content to email messages](dynamic-email-content.md) and [The form element for marketing pages](content-blocks-reference.md#the-form-element-for-marketing-pages)

You can create customer journeys that include triggers that react to marketing page submissions, so that contacts who submit the page are treated differently from those who don't. To do this, include a marketing page tile in your journey design and then place a trigger that references that tile and specifies logic for how to react to it. To trigger on a marketing page linked to in a marketing-email message, add an email tile for the message and then add a marketing page tile as a child tile of that message. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)

## View submitted data and analyze page performance

To view form submissions and analytics about page usage and performance:

1. Go to **Lead Management** &gt; **Marketing Pages** and use the search, sort, and filtering controls to find the page you want to inspect.

1. Use the drop-down list above the marketing-page name to switch to the **Insights** entity form.

    ![The form selector menu](media/form-selector-insights.png "Choose Insights from the form selector")

1. Explore the various tabs and displays here to view submissions and gain insights.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Analyze results to gain insights from your marketing activities](insights.md)

## Configure marketing page defaults and matching strategies

Administrators can choose settings that control several aspects of the way all marketing pages function on your site and the way they match incoming page submissions to existing contacts and leads. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Configure marketing pages](marketing-settings.md#config-mkt-pages)

### See also

[Create a landing page](create-landing-page.md)  
[Design your digital content](design-digital-content.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)  
[Design elements reference](content-blocks-reference.md)  
[Upload and use images and files](upload-images-files.md)  
[How Dynamics 365 for Marketing uses cookies](cookies.md)  
[Go live with publishable entities and track their status](go-live.md)
