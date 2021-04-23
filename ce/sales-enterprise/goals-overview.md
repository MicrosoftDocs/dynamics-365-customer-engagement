---
title: "Process for setting goals (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define, track, and measure performance-based Sales and Customer Service goals in Dynamics 365."
ms.date: 04/19/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Process for Setting Goals

With Dynamics 365, you can define, measure, and track goals for your organization and team. For example, your sales organization can define goals based on sales revenue for a specific territory, number of leads created, number of units sold, and so on. Similarly, your customer service organization can define goals based on the number of cases closed.

You can create parent goals based on criteria like market research, budget planning, and historical performance. You'll typically assign parent goals to managers, and then assign child goals to individuals, teams, organizations, territories, and product lines. These child goals roll up into the overall goals for a specified metric.  

For example, a parent goal might be to generate a certain number of sales leads during a quarter. Child goals assigned to territories, teams, or individuals would be for their portion of the parent goal. You can track child goals separately, with each child goal contributing to the parent goal. The actual and in-progress results of the child goals roll up to parent goals during a scheduled rollup or through a manual trigger.

To set goals, consider these factors:

- [Goal hierarchy](#define-goal-hierarchy)  
- [Setting goal metrics](#set-goal-metrics)  
- [Defining rollup queries](#define-rollup-queries)
- [Setting targets](#set-targets)  
- [Setting time periods for goals](#set-time-periods-for-goals)  
- [Monitoring goals](#monitor-goals)  
- [Goals and security roles](#understand-goals-and-security-roles)  

## Define Goal hierarchy

Typically, a manager's goal is a total of the goals assigned to their staff. A large organization's goal could be a combination of regional sales or service goals.

A staff goal is a child goal of a manager's goal, which in turn can have a parent goal at the regional level, and so on. A goal can have only one parent goal, but a parent goal can have multiple child goals.

Deleting a parent goal does not delete the child goal. Deleting a parent goal only removes the reference to the parent goal for the child goal.

The goal rollup is done from the bottom of the hierarchy to the top. During rollup, the parent goal total is the sum of all its child goals.

## Set goal metrics

There are two types of goal metrics:

- **Count:** Counts things that you track, such as how many sales phone calls were completed in a given period.

- **Amount:** Tracks things like revenue or sales measured in something other than whole numbers. This metric is more versatile. You could use the amount metric to track sales of a product sold by weight, or to make a goal more specific, such as the number of sales calls that lasted longer than five minutes, instead of only the total number of calls made.

If your metric type is Amount, you need to further specify the amount data type:

- **Money:** Tracks a monetary amount, such as revenue from a product line.

- **Integer:** Tracks anything countable in whole numbers, such as units sold.

- **Decimal:** Tracks data that include partial numbers, such as pounds sold of a product that is sold by weight.

If your metric type is Count, the data type is always an integer.

> [!NOTE]
> After you select the metric type and data type, and then save the metric, you cannot change the type.

The metric type and amount data type determine the kind of data you can track when you create a rollup field to track the goal. The rollup fields that you define appear in the goal form and also in the grid on the Goals area. You can create or edit rollup fields only from the Goal Metric form.

You must have at least one of the following rollup fields, but you cannot have more than one per type.

- **Actual:** Can be modified as Actual (Money), Actual (Integer), or Actual (Decimal), depending on the data type. This shows the actual amount or count of finished measurable results, such as closed invoices or sales called completed.

- **In-Progress:** Can be modified as In-progress (Money), In-progress (Integer), or In-progress (Decimal), depending on the data type. This includes measurable results that could contribute to a goal, but are not counted yet as actual. For example, an in-progress rollup field that shows qualified leads that have not been contacted could help you track progress toward contacting leads.

- **Custom Rollup Field:** Can be modified as Custom Rollup Field (Money), Custom Rollup Field (Integer), or Custom Rollup Field (Decimal), depending on the data type. Use this to track a third category for results. You could use the actual result to show contacted leads, the in-progress rollup field to track qualified leads, and the custom rollup field to track new leads.

More information: [Create or edit a goal metric](create-edit-goal-metric.md)

## Define rollup queries

Goals roll up from the bottom of the goal hierarchy to the top, with Dynamics 365 rolling child goal totals into their parent goal totals. Goals at the top of a hierarchy reflect a summation of all the goals in the organization.

When you define rollup queries, you identify the record types to compare against the goals you define in the rollup fields. For example, you could create a goal metric that measures all invoices closed within a specific period. You could then create a rollup query to show invoices that are owned by a person, or raised for customers in a territory.

You can only query one entity type in a query, but the query builder helps you make a query as simple or as complex as you need. As you fine-tune your query, you can test the results.

More information: [Create or edit a rollup query](create-edit-goal-rollup-query-sales.md)

## Set targets

You can specify a target value for each goal for measuring the results of the goal rollup, and you can also specify a stretch target for each goal. A target revenue goal for one product line might be $100,000, with a stretch target of $120,000.

More information: [Create or edit goals](create-edit-goal-sales.md)

## Set time periods for goals

You can set a fiscal period, such as a quarter or year, or a custom period, such as a campaign or sales event.

If your organization merges with another organization that uses different time periods, you can change yours to match with the new organization.

Changing a fiscal year or fiscal period does not automatically change the dates for the goals; you will need to update them to show the new dates as a separate step.

More information: [Create or edit goals](create-edit-goal-sales.md)

## Monitor goals

You can monitor goals using the business intelligence tools in Dynamics 365.

You can set up a customized dashboard to list goals you track, or a report that has a complete view of a team's goal and performance toward it.

## Understand goals and security roles

User roles limit what each user can see, depending on what type of access they have and what kinds of records they need to view. Dynamics 365 allows you to set security on an entity or on a specific field. This helps to keep access to information from users who should not see it.

Setting goals is typically a multi-layered process in which child goals roll up into parent goals. A user might create a goal using entities or fields that the user is restricted from viewing, or they might be able to add child goals that include entities or fields they can not view.

For example, User One creates a goal that references a restricted entity that User One has permission to view. User Two cannot view this entity in User One's goal, but can create a parent goal that includes it. When User Two rolls up the parent goal's results, User Two sees aggregated rollup data that includes data from the restricted entity, but still cannot see User One's restricted data by itself.