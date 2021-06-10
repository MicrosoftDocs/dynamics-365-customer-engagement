---
title: "Glossary of common insights terms (Dynamics 365 Marketing) | Microsoft Docs"
description: "Provides definitions of terms commonly used to describe marketing results, insights, and KPIs in Dynamics 365 Marketing."
ms.date: 03/08/2019
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

# Insights glossary

This topic provides definitions of terms commonly used to describe marketing results, insights, and KPIs. Many, but not all, of these relate to email results, and the definitions here also include a few technical details about how these results are found and calculated.

More information: [Analyze results to gain insights from your marketing activities](insights.md)

<dl>
<dt><strong>Contact  stopped in journey</strong></dt>
<dd>From time to time, a contact may get stopped in the middle of a customer journey for some reason, in which case they will wait at the tile where they were stopped until conditions change again (but typically they won't). There are three main reasons why a contact might get stopped at a tile during a journey: they unsubscribed from the mailing list targeted by the journey while it was running, they joined the journey's suppression segment while it was running, or the lowered their consent level to be below the minimum threshold set for the journey while it was running. Unsubscribes are counted together with suppression list changes.</dd>

<dt><strong>Email block bounced</strong></dt>
<dd>A block bounce is registered for emails messages that bounce for some reason other than a hard or soft bounce. This result is rare, and might indicated a remote bounce, which occurs when a server initially accepts an email, but then returns a bounce message sometime later. This might happen when the receiving email server is running local filtering rules that identify issues such as lack of sender authentication, flagged content, or because the sending IP is on a block list. These are otherwise treated as soft bounces.</dd>

<dt><strong>Email blocked</strong></dt>
<dd>The message was blocked due to rules established within Dynamics 365 Marketing, so no attempt to send it was made.  Blocking can occur when: a contact is marked as "Do not bulk email" and/or "Do not email"; the send list includes duplicate email addresses; you've used up your send quota for the month;  the message includes invalid, missing, or block listed addresses for the recipient, sender, and/or reply-to; other required fields are missing for the message. Examples of block listed addresses include known anonymous email servers and generic addresses such as do-not-repy@constoso.com or office@contoso.com.</dd>

<dt><strong><a name="email-click"></a>Email clicked</strong></dt>
<dd>Each reported email click indicates that a contact clicked on a link sent to them in a marketing email. All links included in marketing emails are modified to redirect through Dynamics 365 Marketing and to include information about which message included the link and which contact it was sent to. So on each click, Dynamics 365 Marketing notes the click, the message that contains it, and the contact who clicked on it, and then forwards the contact on to the page originally specified by the message designer. Marketing can report both total clicks and unique clicks. Unique clicks count at most one click on each link by each recipient. Total clicks also count multiple clicks of the same link by any recipient, so total click values could sometimes be larger than the number of opens or deliveries for a given message.  The technique used to register clicks can sometimes produce misleading results when a message is forwarded&mdash;see <a href="#email-forwarded">Email forwarded</a> in this glossary for details.</dd>

<dt><strong>Email click-through rate (CTR)</strong></dt>
<dd>The email click-through rate indicates how often a message delivery resulted in at least one click on any of the links it contains. It’s reported as a percentage of total deliveries. Only unique clicks are counted, so after the first click, it doesn’t matter how many links a recipient clicks on, or how many times. For more information about how clicks are counted, see <a href="#email-click">Email clicked</a> in this glossary.<br/>
<code>EmailCTR = (UniqueMessageClicks/TotalDelivered) * 100%</code></dd>

<!-- add CTOR here -->

<dt><strong><a name="email-delivered"></a>Email delivered</strong></dt>
<dd>A marketing email message is considered to have been delivered if it was sent (not blocked) by Dynamics 365 Marketing and no bounce was reported. Messages reported as delivered might still end up unopened or caught in a spam filter along the way.<br/>
<code>Delivered = SegmentContacts –  DuplicateContacts – BlockedContacts – StoppedContacts –  HardBounces – SoftBounces – BlockBounces</code></dd>

<dt><strong>Email feedback loop</strong></dt>
<dd>A feedback loop occurs when an email gets delivered and then a recipient's email client  returns a feedback message to Dynamics 365 Marketing. This typically means that the recipient used their email client to mark the message as spam. If you continue to send messages to an address that has returned this feedback, you risk lowering your server's send reputation, which will reduce your delivery rate. When feedback is received, Dynamics 365 Marketing will automatically stop sending new messages to that address, but your email results will still show each attempt as a feedback loop.</dd>

<dt><strong><a name="email-forwarded"></a>Email forwarded</strong></dt>
<dd>An email is registered as forwarded each time an original recipient uses a Dynamics 365 Marketing forward-to-a-friend marketing page to forward it. If a contact instead forwards a message using their email client, then no forward will be record in Dynamics 365 Marketing, and the forwarded message will still include links and a web beacon that identify the original recipient, so all subsequent opens and clicks will continue to be matched to the original recipient in Dynamics 365 Marketing. If the original recipient instead forwards using a forward-to-a-friend form, then new links and a new web beacon will be generated for the new recipients and all opens and clicks will be correctly attributed to the new recipients. We therefore recommend that you include forward-to-a-friend links in all of your marketing messages and encourage recipients to use them instead of forwarding with their email clients. For more information about web beacons and how email clicks and opens are counted, see <a href="#email-click">Email click</a> and <a href="#email-opened">Email opened</a> in this glossary.</dd>

<dt><strong>Email hard bounced</strong></dt>
<dd>A hard bounce indicates that you tried to send an email message to an address that isn't valid. A hard bounce might occur because the domain name doesn't exist or because the recipient is unknown. Multiple hard bounces can lower your server's send reputation, which will reduce your delivery rate, so you should remove hard-bouncing addresses from your contact records. When an address returns a hard bounce, Dynamics 365 Marketing will automatically stop sending new messages to that address for six months, but your email results will still show each attempt as a hard bounce.</dd>

<dt><strong><a name="email-opened"></a>Email opened</strong></dt>
<dd>An email is registered as having been opened each time a recipient opens the message and allows it to load images. It works because Dynamics 365 Marketing includes an embedded link to a clear, 1x1 pixel image in each message it sends. This type of image is sometimes called a <em>web beacon</em>. The actual web-beacon image is stored on the Dynamics 365 Marketing server, so each time a contact opens the message and loads its images, that message requests the beacon image using a URL that includes information about which message and which contact is requesting it. Marketing can report both total opens and unique opens. Unique opens count at most one open of each message by each recipient. Total opens also count multiple opens of the same message by any recipient. Some lists of email-opened results include information about the browser and operating system that was used, but these values are not available for messages opened on a Gmail client (the open is shown and counted, but the browser and OS values are blank). Note that if a contact doesn't allow the images to load when opening a message, then no open will be recorded, but link clicks will still be counted, which can make it appear as though you have more unique clicks than unique opens. Likewise, web beacons can sometimes produce misleading results when a message is forwarded&mdash;see <a href="#email-forwarded">Email forwarded</a> in this glossary for details.</dd>

<dt><strong>Email processed</strong></dt>
<dd>A processed email is a message that has been successfully rendered for a specific recipient, resulting in a message that is valid and ready to send.<br>
<code>Processed = Inflow - Processing – Stopped – Failed</code></dd>

<dt><strong>Email sent</strong></dt>
<dd>A sent message is one that Dynamics 365 Marketing attempted to deliver to a contact during a customer journey, after removing duplicate, stopped, and blocked contacts.  Some of these messages may still fail to get delivered due to soft or hard bounces.<br>
<code>Sent = SegmentContacts – DuplicateContacts – BlockedContacts – StoppedContacts</code></dd>

<dt><strong>Email soft bounced</strong></dt>
<dd>A soft bounce occurs when an email is sent to a valid server, which recognizes the user, but which still rejects the message for some reason. A soft bounce may occur because the recipient's mailbox is full, the mail server is temporarily unavailable, or the  email account has been closed. If five messages in a row sent to a given address result in a soft bounce, then Marketing will treat that address as a hard-bouncing address and stop trying to send to it.</dd>

<dt><strong>Email unopened</strong></dt>
<dd>The number of times a message was delivered, but no open was recorded. See also <a href="#email-opened">Email opened</a> and <a href="#email-delivered">Email delivered</a> in this glossary for more information about how these values are found.<br/>
<code>Unopened = TotalDelivered – UniqueOpens</code></dd>

<dt><strong>Form submitted</strong></dt>
<dd>A form submission is recorded each time somebody submits a marketing form. This includes both forms that are placed on a marketing page and forms that are embedded on an external site.</dd>

<dt><strong>Form visited</strong></dt>
<dd>A form visit is recorded each time somebody opens a page that includes a marketing form. This includes both forms that are placed on a marketing page and forms that are embedded on page on an external site.</dd>

<dt><strong>Link click-through rate (CTR)</strong></dt>
<dd>The link click-through rate indicates how often a specific link in a specific message was clicked by any recipient at least once. It’s reported as a percentage of total deliveries. Only unique clicks are counted, so after the first click, it doesn’t matter how many times a recipient clicks the link. For more information about how clicks are counted, see <a href="#email-click">Email clicked</a> in this glossary.<br/>
<code>LinkCTR = (UniqueLinkClicks/TotalDelivered) * 100%</code></dd>

<dt><strong>Page submitted</strong></dt>
<dd>A page submission is recorded each time somebody submits a marketing page that includes a marketing form. This only includes pages hosted on a Power Apps portal, not submissions of marketing forms that are embedded on a page on an external site.</dd>

<dt><strong>Page visited</strong></dt>
<dd>A page visit is recorded each time somebody visits a marketing page. This only includes pages hosted on a Power Apps portal, not pages on external sites that have a Dynamics 365 Marketing website tracking script.</dd>

<dt><strong>Redirect URL clicked</strong></dt>
<dd>Redirect URLs create links that connect to your Dynamics 365 Marketing server, which records the click, and then redirect immediately to some content that the requester is looking for. You can use them to track clicks from banners, ads, social media posts, and more. If a redirect URL is clicked by a known contact using a browser where a Dynamics 365 Marketing cookie has been set (as a result of submitting a landing page), then the click is linked to the relevant contact; otherwise the click is recorded as anonymous.</dd>

<dt><strong>Subscription submitted</strong></dt>
<dd>A contact clicked on the subscription center link sent to them in email, and then submitted the subscription center at least once, regardless of whether the contact changed their subscriptions or contact details.

<dt><strong>Total generated leads</strong></dt>
<dd>The number of leads generated as a result of an email message. A new lead is counted when a recipient clicks a landing-page link in the message and then submits the landing page, which generates a new lead for that contact as a result. Landing page submissions that don't generate a new lead aren't counted (for example, because a matching lead already exists or because the landing page isn't set up to generate leads).

<dt><strong>Unsubscribed</strong><</dt>
<dd>A recipient clicked on the subscription center link in an email and then unsubscribed from one or more mailing lists. This value counts, at most, one unsubscribe per message per recipient.</dd>

<dt><strong>Web beacon</strong></dt>
<dd>Web beacons are what makes it possible for Dynamics 365 Marketing to detect when a marketing email messages has been opened by a recipient. The beacon is a transparent, 1x1 pixel, remote image that Dynamics 365 Marketing embeds in each marketing email it sends. The image link is unique for each message, and includes not only the URL of the image to load, but also an ID that Dynamics 365 Marketing uses to identify the message and the contact it was sent to. The actual web-beacon image is stored on the Dynamics 365 Marketing server, so each time a contact opens a message and loads its images, Dynamics 365 Marketing logs which message was opened and by whom and then returns the image.</dd>

<dt><strong>Website clicked</strong></dt>
<dd>A website click is recorded each time somebody clicks a link on a page that includes a Dynamics 365 Marketing website tracking script. This includes both marketing pages hosted on a Power Apps portal and external pages that host a form or tracking script created with Dynamics 365 Marketing. The feature uses a cookie to uniquely identify each web browser that visits a site, but each visitor is anonymous until he or she submits a marketing page with form values that match an existing contact or create a new one. If a known contact switches to a new device, a new browser, or to private-browsing mode, website visits will again be recorded as anonymous until that contact submits a marketing page using that device/browser combination.</dd>

<dt><strong>Website visited</strong></dt>
<dd>Dynamics 365 Marketing records a website visit each time somebody loads a page that includes a website tracking script created using Dynamics 365 Marketing. This includes both marketing pages hosted on a Power Apps portal and external pages that host a form or tracking script created with Dynamics 365 Marketing. The feature uses a cookie to uniquely identify each web browser that visits a site, but each visitor is anonymous until he or she submits a marketing page with form values that match an existing contact or create a new one. If a known contact switches to a new device, a new browser, or to private-browsing mode, website visits will again be recorded as anonymous until that contact submits a marketing page using that device/browser combination.</dd>
</dl>

[!INCLUDE[footer-include](../includes/footer-banner.md)]