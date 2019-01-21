---
title: "Glossary of common insights terms (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Provides definitions of terms commonly used to describe marketing results, insights, and KPIs in Dynamics 365 for Marketing"
keywords: insights;results;KPIs;analytics;glossary
ms.date: 01/17/2019
ms.service: dynamics-365-marketing
ms.custom:
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 9aade3aa-ff88-4d32-a3fd-8db3a4ad70ed
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

# Insights glossary

This topic provides definitions of terms commonly used to describe marketing results, insights, and KPIs. Many, but not all, of these relate to email results, and the definitions here also include a few technical details about how these results are found and calculated.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Analyze results to gain insights from your marketing activities](insights.md)

<dt>Contact  stopped in journey</dt>
<dd>From time to time, a contact may get stopped in the middle of a customer journey for some reason, in which case they will wait at the tile where they were stopped until conditions change again (but typically they won't). There are three main reasons why a contact might get stopped at a tile during a journey: they unsubscribed from the mailing list targeted by the journey while it was running, they joined the journey's suppression segment while it was running, or the lowered their consent level to be below the minimum threshold set for the journey while it was running. For consent, the system notes whether the consent is being managed internally or externally. Unsubscribes are counted together with suppression list changes.</dd>

<dt>Email block bounce</dt>
<dd>A block bounce is registered for emails messages that bounce for some reason other than a hard or soft bounce. This result is rare, and might indicated a remote bounce, which occurs when a server initially accepts an email, but then returns a bounce message sometime later. This might happen when the receiving email server is running local filtering rules that identify issues such as lack of sender authentication, flagged content, or because the sending IP is on a blacklist. These are otherwise treated as soft bounces.</dd>

<dt>Email blocked</dt>
<dd>The message was blocked due to rules established within Dynamics 365 for Marketing, so no attempt to send it was made.  Blocking can occur when: a contact is marked as "Do not bulk email" and/or "Do not email"; the send list includes duplicate email addresses; you've used up your send quota for the month;  the message includes invalid, missing, or blacklisted addresses for the recipient, sender, and/or reply-to; other required fields are missing for the message. Examples of blacklisted addresses include known anonymous email servers and generic addresses such as do-not-repy@constoso.com or office@contoso.com.</dd>

<dt><a name="email-click">Email clicked</a></dt>
<dd>Each reported email click indicates that a contact clicked on a link sent to them in a marketing email (not including clicks on links to a subscription center or forward-to-a-friend page&mdash;these are counted separately). All links included in marketing emails are modified to redirect through Dynamics 365 and to include information about which message included the link and which contact it was sent to. So on each click, Dynamics 365 notes the click, the message that contains it, and the contact who clicked on it, and then forwards the contact on to the page originally specified by the message designer. Marketing can report both total clicks and unique clicks. Unique clicks count at most one click on each link by each recipient. Total clicks also count multiple clicks of the same link by any recipient, so total click values could sometimes be larger than the number of opens or deliveries for a given message.  The technique used to register clicks can sometimes produce misleading results when a message is forwarded&mdash;see <a href="#email-forwarded">Email forwarded</a> in this glossary for details.</dd>

<dt>Email click-through rate (CTR)</dt>
<dd>The click-through rate (CTR) tells you how many email clicks were generated as a proportion of the total number delivered (as a percentage).<br/>
<code>CTR = (UniqueClicks/TotalDelivered) * 100</code></dd>

<dt><a name="email-delivered">Email delivered</a></dt>
<dd>A marketing email message is considered to have been delivered if it was sent (not blocked) by Dynamics 365 and no bounce was reported. Messages reported as delivered might still end up unopened or caught in a spam filter along the way.<br/>
<code>Delivered = SegmentContacts –  DuplicateContacts – BlockedContacts – StoppedContacts –  HardBounces – SoftBounces – BlockBounces</code></dd>

<dt>Email feedback loop</dt>
<dd>A feedback loop occurs when an email gets delivered and then a recipient's email client  returns a feedback message to Dynamics 365. This typically means that the recipient used their email client to mark the message as spam. If you continue to send messages to an address that has returned this feedback, you risk lowering your server's send reputation, which will reduce your delivery rate. When feedback is received, Dynamics 365 will automatically stop sending new messages to that address, but your email results will still show each attempt as a feedback loop.</dd>

<dt><a name="email-forwarded">Email forwarded</a></dt>
<dd>An email is registered as forwarded each time an original recipient uses a Dynamics 365 forward-to-a-friend marketing page to forward it. If a contact instead forwards a message using their email client, then no forward will be record in Dynamics 365, and the forwarded message will still include links and a web beacon that identify the original recipient, so all subsequent opens and clicks will continue to be matched to the original recipient in Dynamics 365. If the original recipient instead forwards using a Dynamics 365 forward-to-a-friend form, then new links and a new web beacon will be generated for the new recipients and all opens and clicks will be correctly attributed to the new recipients. We therefore recommend that you include forward-to-a-friend links in all of your marketing messages and encourage recipients to use them instead of forwarding with their email clients. For more information about web beacons and how email clicks and opens are counted, see <a href="#email-click">Email click</a> and <a href="#email-opened">Email opened</a> in this glossary.</dd>

<dt>Email hard bounced</dt>
<dd>A hard bounce indicates that you tried to send an email message to an address that isn't valid. A hard bounce might occur because the domain name doesn't exist or because the recipient is unknown. Multiple hard bounces can lower your server's send reputation, which will reduce your delivery rate, so you should remove hard-bouncing addresses from your contact records. When an address returns a hard bounce, Dynamics 365 will automatically stop sending new messages to that address for six months, but your email results will still show each attempt as a hard bounce.</dd>

<dt><a name="email-opened">Email opened</a></dt>
<dd>An email is registered as having been opened each time a recipient opens the message and allows it to load images. It works because Dynamics 365 for Marketing includes an embedded link to a clear, 1x1 pixel image in each message it sends. This type of image is sometimes called a web beacon. The actual web-beacon image is stored on the Dynamics 365 server, so each time a contact opens the message and loads its images, that message requests the beacon image using a URL that includes information about which message and which contact is requesting it. Marketing can report both total opens and unique opens. Unique opens count at most one open of each message by each recipient. Total opens also count multiple opens of the same message by any recipient.  Note that if a contact doesn't allow the images to load when opening a message, then no open will be recorded, but link clicks will still be counted. The technique used to register opens can sometimes produce misleading results when a message is forwarded&mdash;see <a href="#email-forwarded">Email forwarded</a> in this glossary for details.</dd>

<!-- find def for "Email processed" and put it here -->

<dt>Email sent</dt>
<dd>A sent message is one that Dynamics 365 attempted to deliver to a contact during a customer journey, after removing duplicate, stopped, and blocked contacts.  Some of these messages may still fail to get delivered due to soft or hard bounces.<br>
<code>Sent = SegmentContacts –  DuplicateContacts – BlockedContacts – StoppedContacts</code></dd>

<dt>Email soft bounced</dt>
<dd>A soft bounce occurs when an email is sent to a valid server, which recognizes the user, but which still rejects the message for some reason. A soft bounce may occur because the recipient's mailbox is full, the mail server is temporarily unavailable, or the  email account has been closed. If five messages in a row sent to a given address result in a soft bounce, then Marketing will treat that address as a hard-bouncing address and stop trying to send to it.</dd>

<dt>Email unopened</dt>
<dd>The number of times a message was delivered, but no open was recorded. See also <a href="#email-opened">Email opened</a> and <a href="#email-delivered">Email delivered</a> in this glossary for more information about how these values are found.<br/>
<code>Unopened = TotalDelivered – UniqueOpens</code></dd>

<dt>Form submitted</dt>
<dd>A form submission is recorded each time somebody submits a Dynamics 365 marketing form. This includes both forms that are placed on a Dynamics 365 marketing page and forms that are embedded on an external site.</dd>

<dt>Form visited</dt>
<dd>A form visit is recorded each time somebody opens a page that includes a Dynamics 365 marketing form. This includes both forms that are placed on a Dynamics 365 marketing page and forms that are embedded on page on an external site.</dd>

<dt>Page submitted</dt>
<dd>A page submission is recorded each time somebody submits a Dynamics 365 marketing page that includes a marketing form. This only includes Dynamics 365 marketing pages, not submissions of marketing forms that are embedded on a page on an external site.</dd>

<dt>Page visited</dt>
<dd>A page visit is recorded each time somebody visits a Dynamics 365 marketing page. This only includes Dynamics 365 marketing pages, not pages on external sites that have a Dynamics 365 website tracking script.</dd>

<dt>Redirect URL clicked</dt>
<dd>Redirect URLs create links that connect to your Dynamics 365 server, which records the click, and then redirect immediately to some content that the requester is looking for. You can use them to track clicks from banners, ads, social media posts, and more. If a redirect URL is clicked by a known contact using a browser where a Dynamics 365 cookie has been set (as a result of submitting a landing page), then the click is linked to the relevant contact; otherwise the click is recorded as anonymous.</dd>

<!-- Write a short def for "web beacon" and put it here -->

<dt>Website clicked</dt>
<dd>A website click is recorded each time somebody clicks a link on a page that includes a Dynamics 365 website tracking script. This includes both marketing pages hosted by Dynamics 365 and external pages that host a form or tracking script created with Dynamics 365 for Marketing. The feature uses a cookie to uniquely identify each web browser that visits a site, but each visitor is anonymous until he or she submits a marketing page with form values that match an existing contact or create a new one. If a known contact switches to a new device, a new browser, or to private-browsing mode, website visits will again be recorded as anonymous until that contact submits a marketing page using that device/browser combination.</dd>

<dt>Website visited</dt>
<dd>Dynamics 365 records a website visit each time somebody loads a page that includes a website tracking script created using Dynamics 365 for Marketing. This includes both marketing pages hosted by Dynamics 365 and external pages that host a form or tracking script created with Dynamics 365 for Marketing. The feature uses a cookie to uniquely identify each web browser that visits a site, but each visitor is anonymous until he or she submits a marketing page with form values that match an existing contact or create a new one. If a known contact switches to a new device, a new browser, or to private-browsing mode, website visits will again be recorded as anonymous until that contact submits a marketing page using that device/browser combination.
