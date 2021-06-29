---
title: "Take Microsoft Teams data a step further with Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to follow up with Microsoft Teams webinar participants using Dynamics 365 Marketing."
ms.date: 06/29/2021
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

# Take Microsoft Teams data a step further with Dynamics 365 Marketing

With Teams and Marketing, you can continue the conversation with webinar participants, using attendance data to build relationships. Let's say you've hosted a Microsoft Teams webinar and are reviewing your [Teams attendance report](/microsoftteams/teams-analytics-and-reports/meeting-attendance-report). Maybe some guests registered but didn't attend, while others canceled their registrations. You wish you could follow up with the guests to get feedback or tell them about an upcoming webinar that is more relevant to their interests.

Marketing helps you automate and personalize the follow-up process. Using Marketing with Teams data, you can:

- Store and manage webinar participant contact information
- Create groups of participants for targeted messaging (for example, participants who attended, who didn't attend, or who canceled)
- Use built-in email templates to send personalized emails that look professionally designed

## Teams versus Marketing terminology

The following bolded terms are tools that the Marketing app uses to organize, personalize, and automate your webinar participant data.

- **Contact**: In Marketing, participant data such as names, email addresses, company names, and mailing addresses are stored as contacts. You can use other tools, such as segments, to group contacts for targeted messaging.
- **Segment**: A segment is a defined group of contacts, such as contacts who work at Contoso and attended a webinar. Segments allow you to choose the right audience to market to.
- **Customer journey**: After you've identified the audience you want to target, you can create a journey that automates a series of communications. For example, you can use a journey to send an email requesting a response from all participants who registered but did not attend a webinar. You may find that the webinar was off topic or was at an inconvenient time, helping you improve your future webinar plans.
- **Customer journey tile**: Each step in a customer journey is represented by a tile. The [tiles represent actions](customer-journey-tiles-reference.md)) that the Marketing app can take. For example, an email tile automatically sends personalized email messages to a segment of your choosing.

## Follow up with webinar participants

In just a few steps, you can use contacts, segments, and a customer journey to follow up with webinar participants, even if you are not an existing Dynamics 365 Marketing user. To follow up with participants:

1. In Teams, select the **Attendance** tab to view the attendance report.
1. In the top-right corner, select **Follow up with participants**.
1. Select **Get started**. If you are an existing Marketing customer, a window pops up that lists your Dynamics organizations. Select the organization you want to use from the dropdown. If you are not a Marketing customer, a window opens that allows you [sign up for a free Dynamics 365 Marketing trial](trial-signup.md).
    > [!div class="mx-imgBorder"]
    > ![Follow up button](media/teams-follow-up-get-started.png "Follow up button")
1. A browser tab then opens with a customer journey and segments that are personalized to your webinar data.
    > [!div class="mx-imgBorder"]
    > ![Generated customer journey](media/team-follow-up-journey.png "Generated customer journey")

## Using your webinar data customer journey

The customer journey uses the power of Dynamics 365 Marketing to follow up with webinar participants on three paths:

- The first path sends an email to registrants who did not attend the webinar.
- The second path sends an email to registrants who attended the webinar.
- The third path sends an email to registrants who canceled their webinar registration.

Each path includes an email template to send notification emails. You can personalize each email template to suit your branding and company needs. To personalize the email, select the **Send an email** tile.

You can also add tiles to create more complex paths for your journey. For example, you could try adding a **Wait for** tile and another **Send an email** tile to wait a week before sending a reminder email.

Refer to the links below to learn more about Marketing features and how to customize your journey.

## Learn more about customizing your journey

The links below guide you through some of the key features of emails, segments, and customer journeys.

- [Create a marketing email and go live](create-marketing-email.md)
- [Create a dynamic segment](create-segment.md)
- [Create a simple customer journey with email messaging](create-simple-customer-journey.md)
- [Customer journey tiles reference](customer-journey-tiles-reference.md)
- [Create an interactive customer journey with conditions and signup](create-interactive-customer-journey.md)

## Additional resources

- [Explore training on Microsoft Learn](/learn/browse/?products=dynamics-marketing)
- [Watch videos on the product playlist](https://www.youtube.com/playlist?list=PLcakwueIHoT_cV1n1es1YJt_T2A5u-XpR)

> [!NOTE]
> Microsoft Teams and Dynamics 365 Marketing each have their own [service-specific licensing terms](https://www.microsoft.com/licensing/terms/productoffering). The service-specific terms that apply depend on which service processes your data. For example, when you transition from Microsoft Teams to Dynamics 365 Marketing, your Microsoft Teams data related to the webinar (such as the attendance report, engagement data, etc.) is transferred to Dynamics 365 Marketing whereupon it becomes Dynamics 365 Marketing data and the Dynamics 365 service-specific terms apply.