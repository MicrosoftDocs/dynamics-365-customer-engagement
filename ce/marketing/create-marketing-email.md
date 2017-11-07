---
title: "Create a marketing email Dynamics 365 for Marketing | Microsoft Docs"
description: "A tutorial for how to create a marketing email in Dynamics 365 for Marketing"
keywords: "tutorial; email; marketing email; assist edit; dynamic content"
ms.date: 11/07/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f19d8015-50ab-4286-af03-dd24ced39308
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Create a marketing email and go live

Email is a vital marketing channel for most modern organizations. It is also a core feature of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], which provides tools for creating graphically rich marketing emails with dynamic, personalized content. [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] can send large volumes of personalized marketing emails, monitor how each recipient interacts with them, drive customer-journey automation based on these interactions, and present results both for individual contacts and with aggregate statistical analytics.


> [!TIP] **Process overview**: To set up and execute a simple email campaign, you must do the following:
> 1.  Create an email design that delivers your message and includes required elements such as a subscription-center link, your physical address, email subject and email-from address.
> 1. Publish the design by choosing **Go live**. This copies the design to the [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] email marketing service, which makes the message available for use by a customer journey (but doesn’t deliver any messages yet). The go-live process also activates any dynamic code and replaces links with trackable versions that redirect through [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
> 1. Set up a customer journey that, at minimum, identifies a published target segment and a published email message to deliver to that segment.
> 1. Activate the customer journey by choosing **Go live**. The journey then drives the email-delivery process and other automation features. It personalizes and sends each individual message, collects interaction data, and can follow up with additional processes based on those interactions.
> 
> This exercise describes how to do the first two of these steps. You’ll set up the last two steps in the [next exercise](create-simple-customer-journey.md).

To create a marketing email and go live:

1. Go to **Marketing &gt; Marketing Execution &gt; Marketing Emails**. This takes you to a list of existing marketing emails.
    ![Location of the new-segment button](media/new-segment-button-location.png "Location of the new-segment button")

    Choose **New** from the command bar.

1. The **New Marketing Email** page opens with the **Select an Email Template** dialog shown. Each template provides a starting point for designing a particular type of message. The template dialog provides tools for searching, browsing, and previewing your template collection.  
    ![Dialog for choosing an email template](media/email-template-dialog.png "Dialog for choosing an email template")

    For this exercise, choose the **blank** template so that you can step through all the required content. Then choose **Select** to apply the template to your new message.

    > [!TIP] Several standard templates are provided out of the box, and you can also create your own templates that feature your own organization’s graphical identity, required elements, and messaging standards. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create templates for emails, pages, forms, and journeys](create-templates.md)

1. The **Select an Email Template** dialog closes and the content (if any) from your selected template is copied into your design. At the top of email designer page are three required fields: **Name**, **Subject**, and **From**. If your browser window is too narrow to show all the fields, you’ll also see a down-pointing arrow that opens a menu where you can see the fields that don’t fit.
    ![Fill out these fields for your new email](media/email-required-fields.png "Fill out these fields for your new email")  

    Enter the following:
    - **Name**: this is an internal name for your message. Enter any name that you will easily recognize later.
    - **Subject**: this is the subject that email recipients will see when they receive the message.
    - **From**: click here to select the [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] user that email recipients will see as the sender of the message.

1. In the main part of the page, you now see the design canvas (on the left), where you can drag, arrange, and enter content. A **Toolbox** on the right provides content blocks that you’ll use to construct your message.
    ![Add a text block to a new email](media/email-add-text-block.png "Add a text block to a new email")  

    Drag a **Text** block from the **Toolbox** tab over to the top of the canvas. When you have dragged the block to a suitable location, a blue shaded region appears. Release the mouse button to drop the block at that location.

1. On dropping the text block, you’ll see some placeholder text within the block and a floating toolbar just below or above it.
   ![The floating text toolbar](media/email-floating-text-toolbar.png "The floating text toolbar")  

   Select and remove the placeholder text, and then add your own. Use the toolbar buttons to style your text as you would in a text editor like [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] (hover your mouse pointer over any toolbar button to see what it does). Most of the buttons are for styling text and paragraphs, but there are also buttons for creating links; entering dynamic text (more on this later); and moving, copying or deleting the entire text block.

    > [!TIP] The very first text that you put on the page is especially important because most email clients show this as *preview text* for the messages in their inbox list. Here is how it looks in [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-outlook-short](../includes/pn-ms-outlook-short.md)]:
    >
    >![How email content looks in the [!INCLUDE[pn-ms-outlook-short](../includes/pn-ms-outlook-short.md)] inbox list](media/email-inbox-list.png "How email content looks in the [!INCLUDE[pn-ms-outlook-short](../includes/pn-ms-outlook-short.md)] inbox list")
    >
    >Messages that come from a familiar *sender* with an enticing *subject* and supporting *preview text* are much more likely to get opened than messages that have just some or none of those things.

1. An easy way to personalize the message is to include the name of the recipient in the greeting. Add the recipient’s name as dynamic text by using the assist-edit feature as follows:

    1. Working in the text block you just added, enter a suitable opening such as “Dear ”.
    1. Choose the assist-edit button, **&lt;/&gt;**, in the pop-up toolbar. This opens a drop-down list at your insertion point in the text block.
    ![Choose an entity using assist edit](media/email-assist-edit-entity.png "Choose an entity using assist edit")  
    1. Choose **Contact** from the assist-edit drop-down list. The assist-edit tool enters code that references the contact entity, advances the insertion point to the next position in the code, and opens a new drop-down list that shows each field from the contact entity.
    ![Choose a field using assist-edit](media/email-assist-edit-field.png "Choose a field using assist-edit")
    1. Choose **firstname** from the assist-edit drop-down list. The assist-edit tool finishes the code so that it references the first-name field from the contact entity. The full salutation now looks like this: **Dear {{contact.firstname}},**. (You could instead enter that code directly without using assist-edit if you prefer.)

   > [!TIP] You may have noticed that the **Subject** field also has an assist-edit button. This means that you can put dynamic text (including the recipient’s name) in the subject too.

1. The body of all email messages must include both a subscription-center link and your organization’s physical address. These are required by law in many jurisdictions, and [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] won’t let you publish any marketing email that doesn’t have them. Most templates have them already, but when you are working with a blank template then you must add them yourself. Like the recipient’s name, you’ll place them using assist-edit as follows:
    1. Choose a suitable location for your physical address and then use assist-edit to place it. Choose **msdyncrm\_contentsettings** from the first drop-down list and **msdyncrm\_addressmain** from the second drop-down list to build the expression: **{{msdyncrm\_contentsettings.msdyncrm\_addressmain}}**.
    1. Choose a suitable location for the subscription-center link and type some anchor text there (such as “manage your subscriptions”). Select the anchor text and then choose the **Link** button ![The link button](media/email-link-button.png "The link button") from the floating toolbar, which opens the **Link** dialog. Select the assist-edit button for the **Link** field and then choose **msdyncrm\_contentsettings** from the first drop-down list and **msdyncrm\_subscriptioncenter** from the second one to build the expression: **{{msdyncrm\_contentsettings.msdyncrm\_subscriptioncenter}}**. Choose **OK** to create the link.  
    ![The email Link dialog](media/email-link-dialog.png "The email Link dialog")  

    > [!TIP] Values that you use often, including required content like the subscription-center link and physical address, are stored in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] as *content settings*. That’s why you chose the *content settings* entity when placing these values with assist-edit. Content settings provide a central location where you can store and update information that you use in most or all your messages.
    > 
    > You can have as many content-settings records as you like, but many organizations use just one. When you set up a customer journey, you’ll also pick the content-settings record used by all messages sent by that journey. This means that you could reuse the same marketing email in different customer journeys, but dynamic values taken from the content-settings record can vary based on which customer journey sends the message.  |

1. You should usually include at least one visible image in your design because this will tempt recipients to load the images, which is required for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] to log the message-open event. Drag an **Image** block from the **Toolbox** onto the canvas. This time, when you drop the block, it shows an image placeholder and the **Details** tab opens, which shows configuration settings for the selected block.  
![Where to set the Source for an image](media/email-image-source.png "Where to set the Source for an image")

1. Choose the **Image Gallery** button ![The browse button](media/email-browse-button.png "The browse button") at the right side of the **Source** field on the **Details** tab. The **Select an Image** dialog opens.  
![The image library browser](media/image-library.png "The image library browser")  
Here you can see all the images that have already been uploaded to your [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] server. Select an image and then choose **Select** to place it in your message design. (If you don’t see any images, choose **Upload a Picture** to add a new one.)

    > [!TIP] When a message goes live, [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] uploads all relevant images from your library to its content-delivery network, where they become available as a single source to all recipients. The images aren’t attached to each message, but instead are included as links that redirect through [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for tracking purposes. Contacts won’t download any images until they open the message, which saves bandwidth both for you and your recipients. When a recipient’s email client requests the images, [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] therefore knows that the message has been opened and by whom.

1. Your message now includes all the minimal required and recommended content, so go to the **Preview** tab to see an approximation of how it will render on various screen sizes, and how its dynamic content will get resolved.
![The email preview and preview settings](media/email-preview-settings.png "The email preview and preview settings")  

    Use the buttons in the left column to choose a screen size and orientation to preview. Use the **Contact** and **Content Settings** fields in the **Properties** column to see how your dynamic content will resolve for various recipients and settings.

1. To make sure your message includes all required content and can be sent, choose **Check for Errors** in the command bar. [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] checks your message and then displays results in the notification bar. Expand the notification bar to read the results.
![The check-for-errors button and notifications](media/email-validation-result.png "The check-for-errors button and notifications")  

    If you followed this procedure, then your message should pass the error check. If it doesn’t, read the error message, fix the reported issue and try again until it passes.

1. Until now, your previews and error checks have been simulated. The final test is to deliver the message to yourself, open it in your email program and inspect the results. Choose **Test Send** in the command bar. A **Quick Create** form slides in from the side.
![Email test-send settings](media/email-test-send-flyout.png "Email test-send settings")  

    Enter your own **Email Address** in the field provided, and select the **Test Contact** and **Test Content Settings** records to use when resolving dynamic content (these work the same as for the simulated preview). Then choose **Save** to send yourself the message. You should receive it in a few minutes.

1. If your message still looks good after you get it in your inbox, you are ready to publish it by choosing **Go live** from the command bar.
![Location of the Go Live button](media/email-golive-button-location.png "Location of the Go Live button")  

    [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] copies your design to the email marketing service, which makes the message available for use by a customer journey (but doesn’t deliver any messages yet). The go-live process also activates any dynamic code and replaces links with trackable versions that redirect through [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] (which identifies the recipient and logs the click). Finally, your message **Status Reason** is updated to **Live**.

    > [!TIP] While the message is live, it’s locked for editing in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]. If you need to edit a live message, you must first open it in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] and then choose **Deactivate** from the command bar.