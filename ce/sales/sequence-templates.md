---
title: "Sequence templates"
description: "Sequence templates provide a set of activities to guide sellers with the next best action to take in a specific scenario."
ms.date: 04/30/2022
ms.topic: article
author: udaykirang
ms.author: udag
---

# Sequence templates

Sequence templates provide a set of activities to guide sellers with the next best action to take in a specific scenario.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Using sequence templates

You can use sequence templates to quickly get started with sequences. Sequence templates provide a set of activities to guide sellers with the next best action to take in a specific scenario, such as getting introduced to a lead and winning the deal.

Sequence templates are available for common scenarios, such as an incoming lead on a website. You can customize the template by adding and removing steps in accordance with your organization's requirements. The following templates are available by default: 

-	[Follow up when contacts don't show up](#follow-up-when-contacts-dont-show-up) 
-	[High volume outbound prospecting](#high-volume-outbound-prospecting) 
-	[Invite to an upcoming event](#invite-to-an-upcoming-event) 
-	[Meeting for product demo requests](#meeting-for-product-demo-requests)
-	[Upcoming account renewal](#upcoming-account-renewal) 
-	[Webinar follow up](#webinar-follow-up) 


## Follow up when contacts don't show up 

The **Follow up when contacts don't show up** sequence template is for the Contact record type. The template helps sellers to follow up with customers when they don't show up for a meeting.

By default, the template contains seven steps (excluding wait time steps) and the sequence takes five days to complete. The template consists of the following process:

1.	Send an email to the customer about the missed meeting, and request another meeting. If the customer replies, make a phone call, and share details about the missed meeting.
2.	If the customer doesn't reply to the email, make a phone call. If the customer answers the call, discuss, and share details about the missed meeting.
3.	If the customer doesn't answer the call, wait for two days, and send an email to schedule a placeholder meeting. If the customer replies to the email, make a phone call, and share details about the missed meeting.
4.	If the customer doesn't reply to the email, reach out to other contacts in the company.

The following flow diagram illustrates the steps included in the template.    

:::image type="content" source="media/st-follow-up-when-contacts-dont-show-up.png" alt-text="Sequence flow diagram of the Follow up when contacts don't show up template." lightbox="media/st-follow-up-when-contacts-dont-show-up-exp.png":::

## High volume outbound prospecting 

The **High volume outbound prospecting** sequence template is for the Lead record type. The template helps sellers to meet prospects and understand their needs and requirements.

By default, the template contains seven steps (excluding wait time steps) and the sequence takes nine days to complete. 

The template consists of the following process:

1.	Send an automated introductory email to the lead with the seller's information, and then research the lead's company and details on LinkedIn to understand the lead.
2.	Make a phone call to the lead. If the lead answers the phone call, discuss, and connect with the lead through LinkedIn. Schedule a meeting with the lead to take the deal to the next stage.
3.	If the lead doesn't answer the phone call, an automated follow-up email is sent; after three days, make a phone call to the lead. If the lead answers the phone call, discuss, and schedule a meeting with the lead to take the deal to the next stage.
4.	If the lead doesn't answer the phone call, wait for two days, and make the final phone call. If the lead answers the phone call, discuss, and schedule a meeting with the lead to take the deal to the next stage.
5.	If the lead doesn't answer the phone call, disqualify the lead.

The following flow diagram illustrates the steps included in the template.

:::image type="content" source="media/st-high-volume-outbound-prospecting.png" alt-text="Sequence flow diagram of the High volume outbound prospecting template." lightbox="media/st-high-volume-outbound-prospecting-exp.png":::

## Invite to an upcoming event 

The **Invite to an upcoming event** sequence template is for the Contact record type. The template helps sellers to build relationships and drive attendance to an upcoming event, such as an online webinar or an offline conference.

By default, the template contains six steps (excluding wait time steps) and the sequence takes five days to complete. 

The template consists of the following process:

1.	Send a personalized email inviting the customer to the event. If the customer replies to the email, send a confirmation email with details about the event.
2.	If the customer doesn't reply to the email, send a follow-up email. If the customer replies to the email, send a confirmation email with details about the event.
3.	If the customer doesn't reply to the follow-up email, make a phone call. If the customer answers the call, discuss, and send a confirmation email with details about the event.
4.	If the customer doesn't answer the call, mark the customer for future events.  

The following flow diagram illustrates the steps included in the template.

:::image type="content" source="media/st-invite-to-an-upcoming-event.png" alt-text="Sequence flow diagram of the Invite to an upcoming event template." lightbox="media/st-invite-to-an-upcoming-event-exp.png":::

## Meeting for product demo requests

The **Meeting for product demo** requests sequence template is for the Opportunity record type. The template helps sellers to get a meeting with users who have requested a product demo.

By default, the template contains nine steps (excluding wait time steps) and the sequence takes five days to complete. 
 
The template consists of the following process:

1.	Send an email to the customer thanking them for showing interest in the product. Research and connect with the customer through LinkedIn. 
2.	Wait for a day, and then send an email to the customer requesting a time slot for the demo. If the customer replies to the email, set up a meeting and demo the product.
3.	If the customer doesn't reply, make a phone call. If the customer answers the phone call, set up a meeting and demo the product.
4.	If the customer doesn't answer the phone call, wait for two days, and make a follow-up phone call. If the customer answers that phone call, set up a meeting and demo the product.
5.	If the customer doesn't answer the follow-up phone call, disqualify the customer.

The following flow diagram illustrates the steps included in the template.

:::image type="content" source="media/st-meeting-for-product-demo-requests.png" alt-text="Sequence flow diagram of the Meeting for product demo requests template." lightbox="media/st-meeting-for-product-demo-requests-exp.png":::

## Upcoming account renewal 

The **Upcoming account renewal** sequence template is for the Account record type. The template reminds account executives about upcoming renewals and recommends steps. 

By default, the template contains 13 steps (excluding wait time steps) and the sequence takes 50 days to complete. 

The template consists of the following process:

1.	Verify the account and renewal details, and then send an email to the customer about the upcoming renewal and request to schedule a meeting to discuss it.
2.	Check the products and features used by the account, and research add-ons that can be proposed. Make a phone call to the customer to answer the questions and pitch the add-ons. 
3.	Note action items from the previous call and work on them. Send an email to schedule a follow-up meeting to answer the questions and resolve any doubts the customer has.
4.	Prepare a renewal quote, and discuss with the sales team for approval. 
5.	Make a phone call to the customer and discuss the approved renewal quotation. Email the quotation to the customer for review, and make a call to finalize the quotation.
6.	Discuss and sign the renewal contract. 
7.	Send an email to thank the customer for signing the renewal contract.

The following flow diagram illustrates the steps included in the template.

:::image type="content" source="media/st-upcoming-account-renewal.png" alt-text="Sequence flow diagram of the Upcoming account renewal template." lightbox="media/st-upcoming-account-renewal-exp.png":::

## Webinar follow up 

The **Webinar follow up** sequence template is for the Lead record type. The template allows sellers to set up a meeting with the customers who have recently attended a webinar or an event. 

By default, the template contains 10 steps (excluding wait time steps) and the sequence takes seven days to complete. 

The template consists of the following process:

1.	Send an automated email thanking customers who attended the webinar, and ask to schedule a meeting to discuss next steps and answer any questions. If the customer replies to the email, send a confirmation email, qualify the lead, and set up a meeting to demo the product.
2.	If the customer doesn't reply to the email, send a follow-up email. If the customer replies to the email, send a confirmation email, qualify the lead, and set up a meeting to demo the product.
3.	If the customer doesn't reply to the follow-up email, make a phone call for next steps. If the customer answers the call, send a confirmation email, qualify the lead, and set up a meeting to demo the product.
4.	If the customer doesn't answer the call, wait for two days, and send a final follow-up email for a meeting. If the customer replies to the email, send a confirmation email, qualify the lead, and set up a meeting to demo the product.
5.	If the customer never replies to the email, disqualify the lead. 

The following flow diagram illustrates the steps included in the template.

:::image type="content" source="media/st-webinar-follow-up.png" alt-text="Sequence flow diagram of the Webinar follow up template." lightbox="media/st-webinar-follow-up-exp.png":::

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Create and activate a sequence](create-and-activate-a-sequence.md)   
[Manage sequences](create-manage-sequences.md)

