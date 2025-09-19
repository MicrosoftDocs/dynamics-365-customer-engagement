---
title: Custom criteria examples for sales teams across industries
description: Explore comprehensive lead qualification criteria and search instructions for financial services, manufacturing, healthcare, technology, and cross-industry scenarios to identify hot prospects.
author: lavanyakr01
contributors:
ms.topic: concept-article
ms.date: 08/14/2025
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Custom criteria examples for sales teams across industries

For the target customer profile in Sales Qualification Agent, you can add custom criteria that are specific to your industry and use case. Learn about adding custom criteria in [Add custom criteria to your handoff criteria](configure-sales-qualification-agent-handoff-criteria.md#add-custom-criteria-to-your-handoff-criteria).

When you add a custom criterion, you need to provide the following information:

- Criterion name
- Criterion description
- Source of information
- Instructions to the agent

The following sections provide examples of custom criteria for different industries, along with their specific details and instructions.


## Custom criterion example with public website data 

- **Criterion name:** Acquisition or expansion

- **Criterion description:** Lead is hot if lead's company name announced a new facility, acquisition, or market expansion within the last 18 months.
   :::image type="content" source="media/add-custom-criterion.png" alt-text="Screenshot of the custom criteria section.":::

- **Website:** `https://www.crunchbase.com`
  :::image type="content" source="media/add-website-custom-criterion.png" alt-text="Screenshot of public website added.":::

- **Instructions:** {{Lead.Company Name}} expansion OR acquisition OR "opens new" OR "new facility" in past 18 months. Capture date and summary; pass if ≤ 18 months.

  To add a Dataverse field to your instruction, enter a forward slash (/) and then select the field from the dropdown list.

  :::image type="content" source="media/custom-criterion-instructions.png" alt-text="Screenshot of the provide instructions dialog.":::

## Custom criterion example with Dataverse fields enriched with external data

The following example shows how to use a Dataverse field enriched with Zoominfo, Dun & Bradstreet, or Clay data. The example assumes that you synched the relevant liquidity event information from Dun & Bradstreet to a custom field `LiquidityEventType` in the `Lead` table. Learn more about the integration in [Configure Sales Qualification Agent to use Dataverse fields enriched by third-party data providers](use-zoominfo-dnb-data-in-sales-qualification-agent.md).


- **Criterion name:** Recent liquidity event

- **Criterion description:** Lead is hot if lead's company completed an IPO, SPAC, or major funding round (Series C+ or ≥ \$50M) in the last 24 months.

- **Dataverse field:** `Lead.LiquidityEventType`

- **Instructions:** {{Lead.Company Name}} IPO OR "initial public offering" OR "raised Series C" OR "funding round \$" in the last 24 months. Extract {{Lead.LiquidityEventType}} and {{Lead.LiquidityEventDate}}.

## Custom criterion examples across industries

The following table provides more examples of custom criteria across various industries, including their names, descriptions, and instructions for the agent. You can define the data source based on a reliable website or a Dataverse field enriched with data from data intelligence providers specific to your industry like Zoominfo or Dun & Bradstreet. 

| Industry/Category         | Criterion Name                   | Description                                                                                      | Instructions                                                                                                                                                                                                                   |
|---------------------------|----------------------------------|--------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Manufacturing             | Capacity expansion               | Lead is hot if lead's company name announced a plant expansion or new production line in the last 12 months. | site:{{Lead.Company Name}} "press" OR "newsroom" OR "media" new production line OR expansion OR "adds capacity" past 12 months.                                                         |
| Manufacturing             | Multi-plant, older facilities    | Lead is hot if lead's company name operates 3+ manufacturing sites and at least one plant is older than 10 years. | site:{{Lead.Company Name}}.com facilities OR plants OR locations manufacturing. Extract plant count and earliest commissioning year.                                                     |
| Manufacturing             | Program award                    | Lead is hot if lead's company name is awarded an OEM or Tier‑1 program in the last 12 months. | {{Lead.Company Name}} awarded contract OR selected supplier OR "program award" automotive past 12 months.                                                                               |
| Healthcare                | Staffed beds threshold           | Lead is hot if total staffed beds across lead's company name ≥ 500.                               | {{Lead.Company Name}} hospital system staffed beds total OR "number of beds" site:aha.org OR site:healthgrades.com. Extract numeric total.                                               |
| Healthcare                | Epic or Cerner                   | Lead is hot if {{Lead.Company Name}}'s primary EHR is Epic or Cerner.                             | {{Lead.Company Name}} EHR Epic OR Cerner site:chimecentral.org OR site:klasresearch.com OR "EHR vendor" "{{Lead.Company Name}}"                                                         |
| Healthcare                | Readmission index                | Lead is hot if {{Lead.Company Name}}'s heart failure 30‑day readmission index is above national average. | {{Lead.Company Name}} compare readmission heart failure for hospital. Extract the index and compare to national average.                                                                     |
| Technology                | Kubernetes + multicloud          | Lead is hot if lead's company name publicly references Kubernetes and uses at least two public clouds. | site:{{Lead.Company Name}}.com blog OR engineering "Kubernetes" AND ("AWS" OR "Azure" OR "GCP"). Count distinct clouds mentioned.                                                        |
| Technology                | Product-led growth signal        | Lead is hot if lead's company name offers self‑serve signup and employs a product analytics role (open role or team page) in the last 6 months. | site:{{Lead.Company Name}}.com pricing OR "Get started" signup AND ("Product Analyst" OR "Growth Analyst" OR "Product Analytics") past 6 months.                                         |
| Technology                | Incident + competitor            | Lead is hot if lead's company name had an email phishing incident in last 12 months AND current vendor is Proofpoint or Mimecast (vendor from Dataverse). | {{Lead.Company Name}} phishing OR business email compromise OR "email security incident" past 12 months.                                                                                 |
| Retail                    | Store count threshold            | Lead is hot if lead's company name operates ≥ 50 retail stores in North America.                  | site:{{Lead.Company Name}}.com "store locator" OR "locations." Count store locations in US+Canada; pass if ≥ 50.                                                                        |
| Cross-industry            | Sustainability report presence   | Lead is hot if lead's company name publishes an annual sustainability/ESG report with Scope 1/2 metrics. | site:{{Lead.Company Name}}.com sustainability report OR ESG "Scope 1" OR "Scope 2".                                                                                                     |
| Cross-industry            | Growth signal                    | Lead is hot if lead's company name has 10+ open roles in targeted functions (for example, "data engineering"). | site:{{Lead.Company Name}}.com/careers "data engineer" OR "data platform" OR "analytics" list open roles; count ≥ 10.                                                                   |
| Cross-industry            | New geography                    | Lead is hot if lead's company name opened offices in a new country/region in the past 12 months.  | {{Lead.Company Name}} opens office OR launches operations in "country/region" site:news past 12 months.                                                                                  |
| Public-database anchored  | CDN and WAF                      | Lead is hot if lead's company name uses a modern CDN and WAF (Cloudflare/Akamai/Fastly).          | {{Lead.Company Name}} technology profile CDN WAF. Identify providers; pass if Cloudflare/Akamai/Fastly present.                                                                         |
| Public-database anchored  | Mobile presence                  | Lead is hot if {{Lead.Company Name}}'s consumer app has ≥ 4.2 rating with ≥ 1,000 reviews.        | {{Lead.Company Name}} app. Extract rating and review count.                                                                                                                             |
| Partner and competition   | Competitor displacement opportunity | Lead is hot if lead's company name publicly lists competitor X as a current vendor.               | {{Lead.Company Name}} "powered by [Competitor X]" OR "case study [Competitor X]" OR "technology partner [Competitor X]".                                                                |
| Partner and competition   | Partner ecosystem fit            | Lead is hot if lead's company name is a certified partner in Microsoft/AWS marketplace with relevant competency. | {{Lead.Company Name}} listing. Extract offer type and competency; pass if "Solution partner—Data & AI" or equivalent.                                                                   |
