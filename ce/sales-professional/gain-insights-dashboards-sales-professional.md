---
title: "Gain insights with dashboards in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Get insights into how your sales team is doing by using dashboards in Dynamics 365 Sales Professional."
ms.date: 10/01/2019
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdyn_salespro
  - D365-Entity-*
  - D365-UI-dashboard
  - Dynamics 365
  - Sales

---

# Gain insights with dashboards in Dynamics 365 Sales Professional

Dashboards in Dynamics 365 Sales Professional provide an overview of actionable business data that's viewable across the organization. Use dashboards to see important data at a glance.

Dashboards use views, lists, and charts to bring data that's meaningful to you to one place.

## Where to find dashboards

To open dashboards, select **Dashboards** in the site map.

## Dashboards in Sales Professional

Sales Professional comes with the following prebuilt dashboards that you can use to quickly get insights on your sales data and team performance.

### Sales Manager Summary dashboard

This dashboard shows data that helps sales managers get important insights on how their sales team is doing. The sales pipeline shows open opportunities in different stages. 

The **Deals Won vs. Deals Lost** chart shows the number of opportunities won or lost by an owner. The dashboard also includes charts that show important financial data, such as estimated versus actual revenue by month.

> [!div class="mx-imgBorder"]
> ![Sales Manager Summary dashboard](media/sales-manager-summary-dashboard.png "Sales Manager Summary dashboard")

### Sales Professional Summary dashboard

This dashboard shows daily work-related sales numbers, such as the activities you're working on, your sales pipeline, and your open opportunities and leads.

> [!div class="mx-imgBorder"]
> ![Sales Professional Summary dashboard](media/sales-professional-summary-dashboard.png "Sales Professional Summary dashboard")

### Sales dashboard

The interactive Sales dashboard helps you review information from various entities and act on it. You can use visual and global filters in the dashboard to quickly get to what's most important.

The Sales dashboard is a multi-stream dashboard, where each stream shows a view of an entity. 
 
> [!div class="mx-imgBorder"]
> ![Sales dashboard](media/sales-dashboard-interactive.png "Sales dashboard")

#### Take quick action on a record in the stream

You can take entity-specific actions right from the stream. For example, in the **Open Leads** stream, select **More options**. From the **More options** menu, you can quickly qualify a lead or assign it to other users.

> [!div class="mx-imgBorder"]
> ![Take quick action on records from the dashboard](media/quick-action-dashboard.png "Take quick action on records from the dashboard")

#### Perform bulk actions

You can select multiple records and take action on all of them at once. Select **Select multiple records to perform bulk actions** ![Select multiple records for bulk action](media/select-multiple-records-bulk-action.png "Select multiple records for bulk action"), select multiple records by selecting the check boxes next to the records, and then select **More Commands** (**...**) to show the actions that can be performed on the selected records.
 
> [!div class="mx-imgBorder"]
> ![Bulk actions on records in the dashboard](media/bulk-actions-dashboard.png "Bulk actions on records in the dashboard")

#### Visual filters in the Sales dashboard

When you select **Show Visual Filter** in a multi-stream dashboard, you see a row of visual filters at the top with the data streams below. 

Visual filters provide a snapshot of key metrics, such as opportunities by account or by rating, or opportunities in different stages of a sales pipeline. 

> [!div class="mx-imgBorder"]
> ![Visual filters in an interactive dashboard](media/visual-filters-interactive-dashboard.png "Visual filters in an interactive dashboard")
 
Use visual filters to display the information that interests you most. For example, when you select the **Hot** area of the **Opportunities by Rating** chart, the dashboard and the streams are refreshed to show only the opportunities that have a **Hot** rating.

> [!div class="mx-imgBorder"]
> ![Hot area selected in the Opportunities by Rating chart](media/opportunities-by-rating-chart.png "Hot area selected in the Opportunities by Rating chart")
 
You'll see the filter applied at the top of the charts. 
 
> [!div class="mx-imgBorder"]
> ![Chart with filters applied](media/chart-with-visual-filters-applied.png "Chart with filters applied")

To remove a specific filter, select the **Close** icon for the applied filter.

> [!div class="mx-imgBorder"]
> ![Remove a visual filter](media/remove-visual-filters.png "Remove a visual filter")
 
To remove all applied filters, select **Clear All**.

#### Global filters in the Sales dashboard

To drill down further into your data, use the global filter. For example, you can apply the global filter to see only those opportunities whose estimated close date is set to a date in the current week. 

To apply a global filter, select **Show Global Filter** on the command bar.

![Global filters in an interactive dashboard](media/global-filters-interactive-dashboard.png "Global filters in an interactive dashboard")
 
After you choose a filter, select **Apply filter** ![Apply filter](media/apply-filter-icon.png "Apply filter"). You can also save this filter for the future by selecting **Save as a reusable filter** ![Save as a reusable filter](media/save-as-reusable-filter.png "Save as a reusable filter").

#### Set the sort order

You can easily switch the sort order in the stream by selecting the field on which you want the data to be sorted. 
 
> [!div class="mx-imgBorder"]
> ![Set the sort order](media/sort-order.png "Set the sort order")

## Open a different dashboard

You can use the view selector to select the dashboard of your choice. Select the view selector, and then select the dashboard you want to open from the drop-down list.

![Dashboard drop-down list](media/dashboard-drop-down-list.png "Dashboard drop-down list")

## Set a dashboard as the default

To see a specific dashboard every time you sign in to Sales Professional, set it as the default. To do this, open the dashboard, and then select **Set as Default** in the site map.

## Entity dashboards

In addition to the dashboards described earlier, some dashboards display information specific to entities. These are available for Account, Contact, Lead, Opportunity, Quote, and Invoice entities. Remember, an entity is the same as a record type.

To see an entity dashboard, go to the list of records for the entity, and then select **Open Dashboards** on the command bar. For example, when you select **Open Dashboard** in the list of opportunities, the following dashboard specific to the Opportunity entity is displayed.

![Entity dashboard for opportunities](media/opportunity-entity-dashboard.png "Entity dashboard for opportunities")

You can use the global or visual filters to show only the data that's important to you.

### See also

[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)<br>
[Learn the basics](learn-basics-sales-professional.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]