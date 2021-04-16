---
title: "Overview of email marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Get an overview for how to create and send marketing email messages in Dynamics 365 Marketing."
ms.date: 08/21/2019
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

# Email marketing overview

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/17c3476e-9383-413b-98ec-0b1ac6659824" frameborder="0" allowfullscreen=""></iframe></div>

The process for creating marketing emails in Dynamics 365 Marketing begins with understanding what makes them such a powerful tool for your marketing campaigns. After you create a good design aimed at a specific segment of your audience, you preview it and check for errors before going live. You can fine-tune the reach and effectiveness of your message through advanced operations like merging database values, adding dynamic content, and introduce programming logic.

## How marketing email works in Dynamics 365 Marketing

Marketing email works quite differently from the person-to-person messaging that you already use. Here are a few of the most important differences:

- **Marketing email messages target entire market segments, but each message is individual**  
    Your marketing email messages aren't just standard messages with giant To or Bcc fields. Long lists of recipients are difficult to manage and analyze, and messages that do this will typically get swept up by spam filters and never be delivered to your contacts. In Dynamics 365 Marketing, you'll target a single marketing email message design to an entire marketing segment, but each individual message is personalized for each recipient and delivered, one at a time, from your organization to the recipient.
- **Mail-merge features enable personalized and dynamic content**  
    You can design your messages to include information that gets personalized for each recipient. For example, each delivered message might include the recipient's name or other content that varies based on the recipient's gender, location, preferred-customer status, or other information from your contact database. Personalized features such as these can greatly improve your open and response rates.
- **Marketing email messages are hosted by the marketing services, so you must "go live" rather than just send messages.**  
    Live messages are hosted by a marketing service linked to your Dynamics 365 Marketing instance, where they are kept ready to be personalized and sent to individual recipients any number of times. You can think of a live marketing email message as a master document that stays on your server and typically includes active logic, ready to generate and send individual email messages when called from a customer journey.
- **Required content and automated error-checking help improve deliverability and ensure compliance**  
    When you try to go live with a message, the system checks for common technical errors and makes sure it includes all required content. Required content includes features that will help maintain your organization's email reputation and features that are typically required by email-marketing regulations in most countries and regions (such as the CAN-SPAM regulations in the United States). Required features include a subscription center link (so contacts can manage their email subscriptions with you), your organization's physical address, a message subject, and a valid return address.
- **Set up a customer journey to deliver messages to a target segment**  
    When your email message is live, it's ready for use in a *customer journey*. The customer journey establishes a target segment (which is a strategically selected list of contacts) and includes logic for working with that segment. For example, the customer journey might target a segment of contacts who live in New York City, and begins by sending an email message announcing an event in the city. The customer journey then applies a "trigger" that separates contacts who sign up for the event from those who don't; customers who sign up receive an automatic thank-you email, while those who haven't signed up within a week will get a reminder email. This customer journey requires three email messages (invite, thank you, and reminder), all of which must be live before you start running the customer journey.
- **You can use a single marketing email message in several marketing contexts**  
    In addition to the ability to merge recipient information and other dynamic content, each marketing email message can also adapt to various marketing contexts defined by the content settings assigned to each customer journey where it's used. Examples of context include supporting page links (such as subscription center and forward pages), your postal address, social-media links, and more. With this feature, you can use a single live email message in several different customer journeys or campaigns.
- **View and analyze message results**  
    Dynamics 365 Marketing keeps track of what happens to the marketing message it sends, and records when each contact opens, clicks, or forwards the message. The system tracks when messages are opened by including a unique [web beacon](https://en.wikipedia.org/wiki/Web_beacon) in each message (recipients must load images for this to work). For each link included in your original message design, Dynamics 365 Marketing creates a redirect link that's unique for each recipient, so all clicks get routed through Dynamics 365 Marketing, which logs the message and contact IDs and forwards the contact to the correct original URL.You can review results and analytics for these and other details grouped by customer journey, email message, email template, and more. More information: [Analyze results to gain insights from your marketing activities](insights.md)
- **You should provide a forwarding form rather than allow contacts to forward messages directly from their email client**  
     Dynamics 365 Marketing provides a forward-to-a-friend feature that contacts should use if they want to share your message with friends or colleagues. This is because the system can track when messages are forwarded by a contact who uses the forward-to-a-friend form, but not when contacts simply forward a message by using their standard email client. Messages forwarded using an email client will still contain the web beacon and personalized links of the original recipient, so your email results will show all interactions with these forwarded messages as being done by the original recipient too&mdash;but when a contact uses the forward-to-a-friend form, Dynamics 365 Marketing generates a new web beacon and personalized redirect links for each forwarded message.

## Process overview: How to create and go live with a marketing email

Below is an overview of the general process for creating and sending a marketing email. Complete details are provided later in related topics.

1. Go to **Marketing** > **Marketing Execution** > **Marketing emails** to open the marketing email list view.

1. Select **New** to [create a new message](email-design.md).

1. Choose a template, which establishes the basic format of your message.

1. Design your message by using the [drag-and-drop designer or HTML editor](design-digital-content.md).

1. Add a compelling **Subject** for your message.

1. [Preview](email-preview.md) your message by using the **Preview** tab and by sending [test messages](email-preview.md).

1. Save your work as often as you want. The message remains in draft status until you go live with it.

1. Run an [error check](email-check-golive.md) on your message. This makes sure you've included all the required elements and haven't introduced any invalid code. If errors are found, you'll see error messages with advice about how to fix them. Fix the errors as suggested, and continue to recheck until the message passes the error check.

1. Select **[Go Live](email-check-golive.md)**. A final error check is done automatically as part of this process, so you won't be able to go live with a message unless it passes the check.

1. The message is now live and ready on your server, but it hasn't been addressed or sent yet; to do that, add it to a [customer journey](customer-journeys-create-automated-campaigns.md).

1. Check your email results to [gain insights](insights.md) based on how contacts interacted with your messages.


### See also

[Tutorial: Create a marketing email and go live](create-marketing-email.md)  
[Create a new email and design its content](email-design.md)  
[Add dynamic content to email messages](dynamic-email-content.md)  
[Set the sender, receiver, language, and legal designation](email-properties.md)
[Check your work using previews and test sends](email-preview.md)  
[Check for errors, go live, and deliver](email-check-golive.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]