---
title: "Create a marketing email (Dynamics 365 Marketing) | Microsoft Docs"
description: "A tutorial for how to create a marketing email in Dynamics 365 Marketing."
ms.date: 12/14/2020
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

# Create a marketing email and go live

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/17c3476e-9383-413b-98ec-0b1ac6659824" frameborder="0" allowfullscreen=""></iframe></div>

Email is a vital marketing channel for most modern organizations. It's also a core feature of Dynamics 365 Marketing, which provides tools for creating graphically rich marketing emails with dynamic, personalized content. Marketing can send large volumes of personalized marketing emails, monitor how each recipient interacts with them, drive customer-journey automation based on these interactions, and present results both for individual contacts and with aggregate statistical analytics.

> [!TIP]
> **Process overview**&mdash;to set up and execute a simple email campaign, you must do the following:
> 1. Create an email design that delivers your message and includes required elements such as a subscription-center link, your physical address, email subject, and email From address.
> 2. Publish the design by selecting **Go live**. This copies the design to the Dynamics 365 Marketing email marketing service, which makes the message available for use by a customer journey (but doesn't deliver any messages yet). The go-live process also activates any dynamic code and replaces links with trackable versions that are redirected through Dynamics 365 Marketing.
> 3. Set up a customer journey that, at a minimum, identifies a published target segment and a published email message to deliver to that segment.
> 4. Activate the customer journey by choosing **Go Live**. The journey then drives the email-delivery process and other automation features. It personalizes and sends each individual message, collects interaction data, and can follow up with additional processes based on those interactions.
> 
> This exercise describes how to do the first two of these steps. You'll set up the last two steps in the [next exercise](create-simple-customer-journey.md).

To create a marketing email and go live:

1. Go to **Marketing** > **Marketing Execution** > **Marketing Emails**. You will see a list of existing marketing emails. Select **New** on the command bar.

    ![Location of the new-email button](media/new-email-button-location4.png "Location of the new-email button")

1. The **New Marketing Email** page opens with the **Select an Email Template** dialog box shown. Each template provides a starting point for designing a particular type of message. The template dialog box provides tools for searching, browsing, and previewing your template collection.

    ![Dialog for choosing an email template](media/email-template-dialog2.png "Dialog box for choosing an email template")

    For this exercise, select the **blank** template so that you can step through all the required content. Then choose **Select** to apply the template to your new message.

   > [!TIP]
   > Several standard templates are provided out of the box, and you can also create your own templates that feature your organization's graphical identity, required elements, and messaging standards. More information: [Create templates for emails, pages, forms, and journeys](create-templates.md)

1. The **Select an Email Template** dialog box closes and the content (if any) from your selected template is copied to your design. Select the **More header fields** button at the side of the header to open a drop-down dialog and then enter a **Name** for your new message.

    ![Enter a name for your new email](media/email-edit-header-fields3.png "Enter a name for your new email")

1. Enter a **Subject** for your message. The subject is an important setting because it is one of the first things recipients will see when they receive the email. Recipients may use the subject to decide whether to open or read the message.

    ![Enter a subject for your new email](media/email-edit-subject2.png "Enter a subject for your new email")

1. In the main part of the page, you now see the design canvas (on the left side), where you can drag, arrange, and enter content. If you chose the blank template, then your design includes just a single one-column section (layout) element with nothing in it. A **Toolbox** on the right side of the page provides design elements that you'll use to construct your message. Drag a **Text** element from the **Toolbox** tab into the section element. When you have dragged the element to a suitable location, a blue shaded region appears. Release the mouse button to drop the element at that location.

    ![Add a text element](media/email-add-text-block.png "Add a text element")

1. When you drop the text element, you'll see some placeholder text within the element and a floating toolbar just below or above it.  

   ![The floating text toolbar](media/email-floating-text-toolbar.png "The floating text toolbar")

   Select and remove the placeholder text, and then add your own. Use the toolbar buttons to style your text as you would in a text editor like Microsoft Word (point to any toolbar button to see what it does). Most of the buttons are for styling text and paragraphs, but there are also buttons for creating links; entering dynamic text (more on this later); and moving, copying, or deleting the entire text element.

   > [!TIP]
   > The very first text that you enter on the page is especially important because most email clients show this as preview text for the messages in their inbox list. Here is how it looks in Microsoft Outlook:
   > 
   > ![How email content looks in the Outlook inbox list](media/email-inbox-list-ill.png "How email content looks in the Outlook inbox list")
   > 
   > Messages that come from a familiar sender that have an enticing subject and relevant preview text are much more likely to get opened than messages that have just some, or none, of those things.

1. An easy way to personalize the message is to include the name of the recipient in the greeting. Add the recipient's name as dynamic text by using the [assist edit](dynamic-email-content.md#assist-edit) feature as follows:

    1. Working in the text element you just added, enter a suitable opening such as "Dear".

    1. On the pop-up toolbar, select the **Assist edit** button ![The assist-edit button](media/button-assist-edit.png "The assist-edit button"). This opens the assist-edit dialog.

    1. Select the **Contextual** radio button, and then select **Contact** from the combo box here. The **Contextual** setting means that you will place a dynamic value related to the context where you use the message, while the **Contact** setting means that the context relates to the individual recipient (contact) of the message.

    1. Select **Next** to continue to the next page of the assit-edit tool.

        ![Assist edit, page 2](media/assist-edit-email-tutorial-p2.png "Assist edit, page 2")

    1. On the previous page, you choose the contact entity (in context). On this page, you must choose which field from that entity you want to place. We're building the salutation, so we'd like to show the recipient's first name here. Select the **Property** radio button and then start to type "first" into the combo box here. This searches the available fields for those that include the text "first," which greatly reduces the number of fields you need to look through. Select **First Name** from the list as soon as you can see it.
    
        > [!NOTE]
        > [Calculated and rollup fields](../customerengagement/on-premises/developer/calculated-rollup-attributes.md) cannot be used in Marketing emails.

    1. Select OK to place the expression you've built and close the assist-edit tool. The full salutation now looks like this: **Dear {{contact.firstname}},**. (If you prefer, you can enter that code directly without using assist edit.)

   > [!TIP]
   > You might have noticed that the **Subject** field also has an assist-edit button. This means that you can put dynamic text (including the recipient's name) in the subject too.

1. The body of all email messages must include both a subscription-center link and your organization's physical address. These are required by law in many jurisdictions, and Dynamics 365 Marketing won't let you publish any marketing email that doesn't have them. These values are provided by the [content settings entity](dynamic-email-content.md#content-settings), which enables you to store their values centrally and change them for each customer journey as needed. Therefore you'll place these as contextual dynamic values, just as you did with the recipient's name (though in this case, the relevant context is the journey rather than the recipient). Place them by using assist edit as follows:

   1. Choose a suitable location for your *physical address*, and then use assist edit to place it. Select **Contextual** and then **ContentSettings** on the first page of the assist-edit tool. Select **Next** and then pick **Property** and **msdyncrm_addressmain** on the second page. Select **OK** to place the expression `{{msdyncrm_contentsettings.msdyncrm_addressmain}}` into your message.

   2. Choose a suitable location for the *subscription-center link*, and then enter some anchor text there (such as "Manage your subscriptions"). Select the anchor text, and then select the **Link** button ![The Link button](media/email-link-button.png "The link button") from the floating toolbar, which opens the **Link** dialog box. Select the **Assist edit** button ![The assist-edit button](media/button-assist-edit.png "The assist-edit button") for the **Link** field. In the assist-edit dialog, select **Contextual** and then **ContentSettings** on the first page. Select **Next** and then pick **Property** and **msdyncrm_subscriptioncenter** on the second page. Select **OK** to place the expression `{{msdyncrm_contentsettings.msdyncrm_subscriptioncenter}}` into the **Link** field.

        ![The email Link dialog](media/email-link-dialog.png "The email Link dialog box")  

1. You should usually include at least one visible image in your design because this will invite recipients to load images, which is required for Dynamics 365 Marketing to log the message-open event. Drag an **Image** element from the **Toolbox** onto the canvas. This time, when you drop the element, you'll see an image placeholder and the **Properties** tab, which shows configuration settings for the selected element.

    ![Where to set the Source for an image](media/email-image-source.png "Where to set the source for an image")

1. On the **Properties** tab, select the **Image gallery** button ![The browse button](media/email-browse-button.png "The browse button") at the right side of the **Source** field. The **Select a file** dialog box opens.

    ![The image library browser](media/image-library.png "The image library browser")  

    Here you can see all the images that have already been uploaded to your Dynamics 365 Marketing server. Select an image, and then choose **Select** to place it in your message design. (If you don't see any images, choose **Upload** to add a new one.)

    > [!TIP]
    > When a message goes live, Dynamics 365 Marketing uploads all relevant images from your library to its content-delivery network, where they become available as a single source to all recipients. The images aren't attached to each message, but instead are included as links that are redirected through Dynamics 365 Marketing for tracking purposes. Recipients won't download any images until they open the message, which saves bandwidth both for you and them. When a recipient's email client requests the images, Dynamics 365 Marketing knows that the message has been opened, and by whom.

1. Your message now includes all the minimal required and recommended content, so go to the **Preview** tab to see an approximation of how it will be rendered on various screen sizes and how its dynamic content will get resolved.

    ![The email preview and preview settings](media/email-preview-settings.png "The email preview and preview settings")  

    Use the buttons in the leftmost column to choose a screen size and orientation to preview. Use the **Contact** and **Content Settings** fields in the **Properties** column to see how your dynamic content will resolve for various recipients and settings.

1. To make sure your message includes all required content and is ready to send, select **Check for Errors** in the command bar. Dynamics 365 Marketing checks your message, and then displays results in the notification bar at the top of the page. If more than one error is found, then select the expansion button to see all of them.

    ![The check-for-errors button and notifications](media/email-validation-result.png "The Check for Errors button and notifications")

    If you followed this procedure, your message should pass the error check. If it doesn't, read the error message, fix the reported issue, and try again until it passes.

1. Until now, your previews and error checks have been simulated. The final test is to deliver the message to yourself, open it in your email program, and inspect the results. On the command bar, select **Test Send**. A **Quick Create** form slides in from the side.

    ![Email test-send settings](media/email-test-send-flyout.png "Email Test Send settings")

    Enter your own **Email Address** in the field provided, and select the **Test Contact** and **Test Content Settings** records to use when resolving dynamic content (these work the same as for the simulated preview). Select **Save** to send yourself the message. You should receive it in a few minutes.

1. If your message still looks good after you receive it in your inbox and open it, you're ready to publish it by selecting **Go Live** on the command bar.

    ![Location of the Go Live button](media/email-golive-button-location.png "Location of the Go Live button")

    Dynamics 365 Marketing copies your design to the email marketing service, which makes the message available for use by a customer journey (but doesn't deliver any messages yet). The go-live process also activates any dynamic code and replaces links with trackable versions that are redirected through Dynamics 365 Marketing (which identifies the recipient and logs the click). Finally, your message **Status Reason** is updated to **Live**

    > [!TIP]
    > While the message is live, it's locked for editing in Dynamics 365 Marketing. If you need to edit a live message, you must first open it in Dynamics 365 Marketing, and then select **Deactivate** on the command bar.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  
[Design your digital content](design-digital-content.md)  
[Keyboard shortcuts and accessibility features for content designers](designer-shortcuts.md)  
[Email marketing overview](prepare-marketing-emails.md)  
[Work with email, page, and form templates](email-templates.md)  
[Design elements reference](content-blocks-reference.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]