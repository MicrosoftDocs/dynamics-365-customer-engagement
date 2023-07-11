---
title: Outbound to real-time playbook
description: Learn how to deploy real-time marketing functionality in Dynamics 365 Marketing.
ms.date: 07/10/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Outbound to real-time playbook

Real-time marketing is the next generation of Dynamics 365 Marketing features. As real-time marketing continues to evolve, almost all the current capabilities and features of outbound marketing will become available in real-time marketing, along with many more modern and enhanced capabilities. You should utilize real-time marketing unless there is a dependency on a specific feature or limitation that has not yet been addressed in real-time marketing.  

## Real-time marketing vs. outbound marketing features

The following table summarizes the benefits of real-time marketing features versus outbound marketing features.

| Scenario                                                                                                                                                                                                                      | Outbound marketing                                                                                                                                                | Real-time marketing                                                                                                                                                               |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Engage customer profiles directly without creating corresponding contacts in Dataverse (when using a third-party customer master/CRM or when there are more profiles in Customer Insights than there are contacts in the CRM) | Not possible                                                                                                                                                      | Seamless (using segments)                                                                                                                                                         |
| Add members from a Customer Insights segment into a new customer journey                                                                                                                                                      | Requires manual segment export from Customer Insights to Makreting; does not provide 100% coverage, you can only target Customer Insights profiles with contacts | Seamless: all Customer Insights segments are automatically available in Marketing                                                                                                 |
| Add members from a Customer Insights segment into an ongoing customer journey (using dynamic segments)                                                                                                                        | Not possible                                                                                                                                                      | Seamless: new members added to a Customer Insights segment are automatically added to Marketing journeys that target that segment                                                  |
| Personalize email content with segments or insights from Customer Insights                                                                                                                                                    | Not possible                                                                                                                                                      | Seamless: Customer Insights attributes, segments, and (soon) measures are automatically available for email personalization, just like any other Dataverse entity                  |
| Branch or suppress a customer journey based on a customer's attributes or segment membership (in Customer Insights)                                                                                                           | Not possible                                                                                                                                                      | Seamless: Customer Insights attributes, segments, and (soon) measures are automatically available for journey logic and suppression criteria, just like any other Dataverse entity |
| Use marketing interaction data to create segments, measures, and other insights in Customer Insights                                                                                                                          | Requires manual data integration                                                                                                                                  | (Coming soon) Marketing interactions are available in Customer Insights without the need for data integration                                                                     |

Learn more about the differences between real-time and outbound features: [Real-time vs outbound marketing journeys!](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/realtime-vs-outbound-marketing-journeys).

## Transition from outbound to real-time marketing

Learn about making the move from outbound to real-time marketing in the free [Transition from outbound to real-time marketing playbook](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/transition-from-outbound-to-real-time-marketing-playbook). The playbook covers key information, including:

- Setting up and configuring Dynamics 365 real-time marketing
- Migrating your marketing artifacts
- Identifying potential challenges
- Retiring the use of outbound marketing

## Default installation of real-time marketing

On September 1, 2023, Dynamics 365 Marketing will transition to focus on real-time marketing features only. New customers will receive a new version of the Marketing app that will only contains real-time marketing features. Although outbound marketing features will continue to be supported for existing users, outbound marketing features will receive no future updates.

## Real-time marketing transition resources

