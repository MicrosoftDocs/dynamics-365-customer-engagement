---
title: Custom criteria examples for sales teams across industries
description: Explore comprehensive lead qualification criteria and search instructions for financial services, manufacturing, healthcare, technology, and cross-industry scenarios to identify hot prospects.
author: lavanyakr01
contributors:
ms.topic: concept-article
ms.date: 08/13/2025
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Custom criteria examples for sales teams across industries

For the target customer profile, you can add custom criteria that are specific to your industry and use case.

When you add a custom criterion, you need to provide the following information:

- Criterion name
- Criterion description
- Source of information
- Instructions to the agent

The following sections provide examples of custom criteria for different industries, along with their specific details and instructions.


## Financial services

**Commercial banking:**

- **Criterion name:** expansion signal

- **Criterion description:** Lead is hot if lead's company name has announced a new facility, acquisition, or market expansion within the last 18 months.
   :::image type="content" source="media/add-custom-criterion.png" alt-text="Screenshot of the add custom criteria section.":::

- **Website:** [www.bing.com](http://www.bing.com)
  :::image type="content" source="media/add-website-custom-criterion.png" alt-text="Screenshot of the add public website dialog.":::

- **Instructions:** site:news {{Lead.Company Name}} expansion OR acquisition
  OR "opens new" OR "new facility" past 18 months. Capture date and
  summary; pass if ≤ 18 months.
  :::image type="content" source="media/custom-criterion-instructions.png" alt-text="Screenshot of the provide instructions dialog.":::

**Wealth management:**

- **Criterion name:** recent liquidity event

- **Criterion description:** Lead is hot if lead's company name completed an
  IPO, SPAC, or major funding round (Series C+ or ≥ \$50M) in the last
  24 months.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} IPO OR "initial public offering" OR
  "raised Series C" OR "funding round \$" in the last 24 months. Extract
  event type and date.

**Insurance (cyber):**

- **Criterion name:** security incident and renewal window

- **Criterion description:** Lead is hot if lead's company name reported a
  phishing/ransomware incident in the last 12 months AND policy renewal
  is within 90 days (renewal from Dataverse).

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} data breach OR ransomware OR
  phishing incident past 12 months. Return incident date and brief.

## Manufacturing

**Capital equipment:**

- **Criterion name:** capacity expansion

- **Criterion description:** Lead is hot if lead's company name announced a
  plant expansion or new production line in the last 12 months.

- **Website:** [www.bing.com](http://www.bing.com)

- **Instructions:** site:{{Lead.Company Name}} "press" OR "newsroom" OR
  "media" new production line OR expansion OR "adds capacity" past 12
  months.

**Industrial IoT retrofit:**

- **Criterion name:** multi-plant, older facilities

- **Criterion description:** Lead is hot if lead's company name operates 3+
  manufacturing sites and at least one plant is older than 10 years.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com facilities OR plants OR locations
  manufacturing. Extract plant count and earliest commissioning year.

**Supplier to automotive:**

- **Criterion name:** program award

- **Criterion description:** Lead is hot if lead's company name has been
  awarded an OEM or Tier‑1 program in the last 12 months.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} awarded contract OR selected
  supplier OR "program award" automotive past 12 months.

## Healthcare

**Provider size:**

- **Criterion name:** staffed beds threshold

- **Criterion description:** Lead is hot if total staffed beds across
  lead's company name ≥ 500.

- **Website:** [www.bing.com](http://www.bing.com)

- **Instructions:** {{Lead.Company Name}} hospital system staffed beds total
  OR "number of beds" site:aha.org OR site:healthgrades.com. Extract
  numeric total.

**EHR footprint:**

- **Criterion name:** Epic or Cerner

- **Criterion description:** Lead is hot if {{Company}}'s primary EHR is Epic
  or Cerner.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} EHR Epic OR Cerner
  site:chimecentral.org OR site:klasresearch.com OR "EHR vendor"
  "{{Company}}".

**Quality signal:**

- **Criterion name:** readmission index

- **Criterion description:** Lead is hot if {{Company}}'s heart failure
  30‑day readmission index is above national average.

- **Website:** [www.medicare.gov](http://www.medicare.gov)

- **Instructions:** {{Lead.Company Name}} hospital compare readmission heart
  failure. Extract the index and compare to national average.

## Technology

**DevSecOps:**

- **Criterion name:** Kubernetes + multi‑cloud

- **Criterion description:** Lead is hot if lead's company name publicly
  references Kubernetes and uses at least two public clouds.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com blog OR engineering "Kubernetes"
  AND ("AWS" OR "Azure" OR "GCP"). Count distinct clouds mentioned.

**SaaS analytics:**

- **Criterion name:** product-led growth signal

- **Criterion description:** Lead is hot if lead's company name offers
  self‑serve signup and employs a product analytics role (open role or
  team page) in the last 6 months.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com pricing OR "Get started" signup AND
  ("Product Analyst" OR "Growth Analyst" OR "Product Analytics") past 6
  months.

**Email security replacement:**

- **Criterion name:** incident + competitor

- **Criterion description:** Lead is hot if lead's company name had an email
  phishing incident in last 12 months AND current vendor is Proofpoint
  or Mimecast (vendor from Dataverse).

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} phishing OR business email
  compromise OR "email security incident" past 12 months.

## Retail

- **Criterion name:** store count threshold

- **Criterion description:** Lead is hot if lead's company name operates ≥
  50 retail stores in North America.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com "store locator" OR "locations."
  Count store locations in US+Canada; pass if ≥ 50.

## Cross‑industry, data-driven criteria

**ESG requirement:**

- **Criterion name:** sustainability report presence

- **Criterion description:** Lead is hot if lead's company name publishes an
  annual sustainability/ESG report with Scope 1/2 metrics.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com sustainability report OR ESG "Scope
  1" OR "Scope 2".

**Hiring momentum:**

- **Criterion name:** growth signal

- **Criterion description:** Lead is hot if lead's company name has 10+ open
  roles in targeted functions (e.g., "data engineering").

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** site:{{Company}}.com/careers "data engineer" OR "data
  platform" OR "analytics" list open roles; count ≥ 10.

**International expansion:**

- **Criterion name:** new geography

- **Criterion description:** Lead is hot if lead's company name opened
  offices in a new country in the past 12 months.

- **Website:** [www.bing.com](http://www.bing.com)

- **Instructions:** {{Lead.Company Name}} opens office OR launches operations
  in "country" OR "region" site:news past 12 months.

## Public-database anchored criteria

**Technology stack:**

- **Criterion name:** CDN and WAF

- **Criterion description:** Lead is hot if lead's company name uses a
  modern CDN and WAF (Cloudflare/Akamai/Fastly).

- **Website:** [builtwith.com](http://builtwith.com)

- **Instructions:** {{Lead.Company Name}} technology profile CDN WAF.
  Identify providers; pass if Cloudflare/Akamai/Fastly present.

**App ratings:**

- **Criterion name:** mobile presence

- **Criterion description:** Lead is hot if {{Company}}'s consumer app has ≥
  4.2 rating with ≥ 1,000 reviews.

- **Website:** [play.google.com](http://play.google.com)

- **Instructions:** {{Lead.Company Name}} app. Extract rating and review
  count.


## Partner and competition criteria

**Competitor displacement opportunity:**

- **Criterion name:** competitor displacement opportunity

- **Criterion description:** Lead is hot if lead's company name publicly
  lists competitor X as a current vendor.

- **Website:** [www.google.com](http://www.google.com)

- **Instructions:** {{Lead.Company Name}} "powered by \[Competitor X\]" OR
  "case study \[Competitor X\]" OR "technology partner \[Competitor
  X\]".

**Partner ecosystem fit:**

- **Criterion name:** partner ecosystem fit

- **Criterion description:** Lead is hot if lead's company name is a
  certified partner in Microsoft/AWS marketplace with relevant
  competency.

- **Website:**
  [azuremarketplace.microsoft.com](http://azuremarketplace.microsoft.com)

- **Instructions:** {{Lead.Company Name}} listing. Extract offer type and
  competency; pass if "Solution partner—Data & AI" or equivalent.
