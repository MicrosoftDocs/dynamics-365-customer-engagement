---
title: "Create an interactive customer journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "A tutorial for how to create an interactive customer journey featuring signups and conditions in Dynamics 365 Marketing."
ms.date: 10/08/2020
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

# Create an interactive customer journey with conditions and signup

In [Create a simple customer journey with email messaging](create-simple-customer-journey.md), you created a customer journey that sends an email message to all contacts in a segment. Now we'll go a bit deeper into customer journeys to see how to add interactive features and decision points by including landing pages and conditions in the design.

1. Go to **Marketing** > **Marketing Execution** > **Marketing Emails** and create a new email message like the one you made in [Create a marketing email and go live](create-marketing-email.md). Be sure to include all the minimum requirements&mdash;name, subject, from-contact, subscription center link, and sender physical address—but don't go live yet.

    > [!TIP]
    > Consider choosing a non-blank email template this time. These templates not only have sample content, graphics, and column layouts, but also include all mandatory elements such as the subscription center link and physical address.

1. This message will invite recipients to pick up a free download from your website. To get the free download, they'll need to visit the landing page, submit a form, and then wait for a follow-up email that contains the download link. (The message content would normally explain all of this, but for this exercise it's not necessary.) With your new email message still open, drag a **Marketing Page** design element from the **Toolbox** onto the design canvas.
  
    ![Add a marketing-page element to a message](media/email-add-page-block3.png "Add a Marketing Page element to a message")

1. When you drop the **Marketing Page** element in place, it is automatically selected and the **Properties** tab opens to show its settings.
 
    ![Assign a page to the page element](media/email-page-block-properties3.png "Assign a page to the page element")

    Set the **Marketing Page** field to the name of the landing page you made in [Create a landing page with a form](create-landing-page.md) (or any valid landing page).  

1. Continue to style and format your button as follows:
   - Edit and style the button text by working directly on the canvas and using the floating toolbar, just as you would with a **Text** element. You might enter text such as **Click here to register for your download**.
   - Working on the **Properties** tab, choose a background color, text color, height, and width for the button.

     ![A page element with styles applied](media/email-page-block-styled2.png "A page element with styles applied")

1. As before, **Save** your message, choose **Check for Errors**, fix any issues, and then **Go Live**.

1. Create two more marketing emails:
   - *A download link message*: This message will be sent after a contact submits the form on the landing page. Set the subject to **Thank you for signing up, here's your download link!** but don't worry too much about the content for now. (In a real project, you would include a link to the promised download here.)
   - *A follow-up message*: This message will be sent if a contact does not submit the form after a few days. Set the subject to **Don't miss out!**, but don't worry too much about the content for now. (In a real project, you would repeat most of the original offer here.)

     Remember to include all required elements and to go live with each of them.

1. Go to **Marketing** > **Marketing Execution** > **Customer Journeys** and create a new customer journey like the one you made in [Create a simple customer journey with email messaging](create-simple-customer-journey.md). As before, add the following:
   - Configure an **Audience** tile in the first position by selecting the **Segment** you made in [Create a dynamic segment](create-segment.md) as the source of the audience.
   - Add an **Email** tile right after the **Audience** tile and configure it to reference the first email message you made for this exercise (with the landing page button).

     ![A customer journey with a simple email campaign](media/journey-email-only2.png "A customer journey with a simple email campaign")  

1. Although your email message includes a link to a landing page, the journey is not aware of that link, or even of the landing page itself. This journey should react to landing page submissions, so you need to reference the marketing page inside the email tile properties. Go to the **Send an email** tile **Properties** and add the correct **Page** item inside the **Email elements** category.
  
    ![Add a marketing page to an email tile](media/journey-add-page2.png "Add a marketing page to an email tile")

1. Now add a condition ("If/then") tile. *If/then tiles* add interactivity to the journey by splitting the pipeline and establishing logical criteria for deciding which path each contact will take. Select an **If/then** tile from the in-place menu on the canvas and add it immediately to the right of the **Send an email** tile.  

    ![Add a if/then tile](media/journey-add-ifthen-tile.png "Add a if/then tile")

1. The **Properties** for the **If/then** tile will automatically appear on the right side of the canvas.
  
     ![Define the if/then rule](media/journey-ifthen-rule-define.png "Define the if/then rule")

     Make the following settings for **Condition**:
    - **Source**: Choose the name of the **Marketing Page** tile you added to the **Send an email** tile properties. This references the name of the marketing page itself.
    - **Condition**: Set to **have registration**.

1. With the **If/then** tile still selected and the **Properties** tab still open, set **Wait up to** to establish how long contacts will wait on this tile before being sent down the false (bottom) path if they don't submit the registration form. Three days is a typical timeout value, but the best choice depends on your circumstances.

    ![Set the if/then timeout](media/journey-ifthen-timeout.png "Set the if/then timeout")

    This expression evaluates to true as soon as a contact submits valid information by using the referenced landing page. Each contact will wait at this condition tile either until its logic evaluates to true or until the **Wait up to** period has elapsed, whichever comes first. As soon as a contact fulfills the requirements, it's sent down the true (top) path; if the Wait up to expires first, the contact is sent down the false (bottom) path instead.

    > [!TIP]
    > Many types of conditions are possible, depending on which types of tiles are available along the pipeline leading to the if/then tile. For example, you might define an if/then condition when a contact just opens the landing page, or define an if/then condition on the email message itself when a contact selects a link or opens the message. You can also establish complex logic by adding several rules and combining them using AND or OR operators.

1. Add two more **Send an email** tiles after the if/then tile, one on the top path and one on the bottom path.  
  
     ![Add an email tile to each path](media/journey-ifthen-paths.png "Add an email tile to each path")  

    Configure the tiles as follows:
    - **Top tile**: This message is sent to contacts who submit the form (when the if/then condition evaluates to true). Configure it to send the download link message that you created earlier in this procedure.
    - **Bottom tile**: This message is sent to contacts who haven't submitted the form within three days of receiving the initial offer. Configure it to send the follow-up reminder message that you created earlier in this procedure.

      > [!TIP]
      > For the purposes of this exercise, you can stop here. But in a real campaign, you would probably repeat most of this pipeline along the bottom path, so that you have a follow-up reminder and then an if/then tile that waits for page submissions. You can reuse the same landing page and download-link message.

1. Save your customer journey. Then, as you've done before, go to the **General** tab to give the journey a name and schedule. Finally, **Check for Errors** and **Go Live**. More information: [Create a simple customer journey with email messaging](create-simple-customer-journey.md)

### See also

[Create a simple customer journey](create-simple-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Create an inbound customer journey](create-inbound-customer-journey.md)  
[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Working with segments](segmentation-lists-subscriptions.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]