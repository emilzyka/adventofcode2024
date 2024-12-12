﻿namespace AdventCode2024.Days;

internal class Day5
{
    // INPUT READING: 

    //string inputPairs = "47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13\r\n";
    string inputPairs = "48|74\r\n95|99\r\n95|97\r\n94|23\r\n94|98\r\n94|56\r\n19|98\r\n19|83\r\n19|62\r\n19|75\r\n83|58\r\n83|49\r\n83|61\r\n83|92\r\n83|93\r\n75|64\r\n75|58\r\n75|39\r\n75|83\r\n75|14\r\n75|24\r\n59|98\r\n59|95\r\n59|23\r\n59|55\r\n59|65\r\n59|69\r\n59|94\r\n77|62\r\n77|28\r\n77|57\r\n77|76\r\n77|34\r\n77|15\r\n77|11\r\n77|26\r\n72|47\r\n72|57\r\n72|81\r\n72|26\r\n72|34\r\n72|28\r\n72|87\r\n72|76\r\n72|19\r\n87|69\r\n87|29\r\n87|63\r\n87|17\r\n87|94\r\n87|57\r\n87|65\r\n87|23\r\n87|33\r\n87|11\r\n99|69\r\n99|29\r\n99|27\r\n99|28\r\n99|81\r\n99|68\r\n99|34\r\n99|77\r\n99|19\r\n99|94\r\n99|76\r\n98|92\r\n98|72\r\n98|23\r\n98|61\r\n98|55\r\n98|69\r\n98|74\r\n98|91\r\n98|39\r\n98|97\r\n98|14\r\n98|63\r\n14|36\r\n14|76\r\n14|99\r\n14|34\r\n14|68\r\n14|11\r\n14|25\r\n14|87\r\n14|19\r\n14|64\r\n14|93\r\n14|39\r\n14|27\r\n27|87\r\n27|55\r\n27|57\r\n27|69\r\n27|19\r\n27|94\r\n27|17\r\n27|65\r\n27|36\r\n27|76\r\n27|29\r\n27|26\r\n27|98\r\n27|68\r\n97|27\r\n97|52\r\n97|72\r\n97|24\r\n97|99\r\n97|87\r\n97|64\r\n97|11\r\n97|39\r\n97|25\r\n97|82\r\n97|59\r\n97|74\r\n97|36\r\n97|57\r\n82|29\r\n82|87\r\n82|62\r\n82|68\r\n82|94\r\n82|57\r\n82|81\r\n82|76\r\n82|11\r\n82|36\r\n82|28\r\n82|77\r\n82|69\r\n82|34\r\n82|19\r\n82|25\r\n63|39\r\n63|52\r\n63|93\r\n63|47\r\n63|25\r\n63|48\r\n63|95\r\n63|64\r\n63|58\r\n63|91\r\n63|56\r\n63|65\r\n63|61\r\n63|83\r\n63|14\r\n63|92\r\n63|72\r\n24|77\r\n24|36\r\n24|33\r\n24|11\r\n24|59\r\n24|15\r\n24|34\r\n24|68\r\n24|27\r\n24|19\r\n24|98\r\n24|28\r\n24|81\r\n24|76\r\n24|17\r\n24|99\r\n24|57\r\n24|82\r\n15|55\r\n15|95\r\n15|65\r\n15|63\r\n15|91\r\n15|74\r\n15|23\r\n15|69\r\n15|92\r\n15|81\r\n15|14\r\n15|49\r\n15|75\r\n15|58\r\n15|48\r\n15|61\r\n15|83\r\n15|33\r\n15|29\r\n52|24\r\n52|25\r\n52|27\r\n52|76\r\n52|34\r\n52|47\r\n52|64\r\n52|82\r\n52|87\r\n52|36\r\n52|28\r\n52|59\r\n52|94\r\n52|72\r\n52|68\r\n52|26\r\n52|62\r\n52|57\r\n52|19\r\n52|11\r\n91|87\r\n91|24\r\n91|92\r\n91|48\r\n91|82\r\n91|39\r\n91|64\r\n91|95\r\n91|14\r\n91|25\r\n91|93\r\n91|77\r\n91|72\r\n91|58\r\n91|61\r\n91|76\r\n91|99\r\n91|52\r\n91|97\r\n91|47\r\n91|56\r\n74|57\r\n74|72\r\n74|19\r\n74|28\r\n74|47\r\n74|25\r\n74|87\r\n74|24\r\n74|11\r\n74|82\r\n74|77\r\n74|59\r\n74|76\r\n74|94\r\n74|36\r\n74|17\r\n74|52\r\n74|26\r\n74|68\r\n74|93\r\n74|34\r\n74|27\r\n34|63\r\n34|62\r\n34|36\r\n34|49\r\n34|33\r\n34|81\r\n34|91\r\n34|15\r\n34|17\r\n34|94\r\n34|29\r\n34|59\r\n34|65\r\n34|75\r\n34|55\r\n34|61\r\n34|83\r\n34|98\r\n34|28\r\n34|58\r\n34|69\r\n34|95\r\n34|23\r\n17|81\r\n17|15\r\n17|95\r\n17|23\r\n17|61\r\n17|97\r\n17|63\r\n17|75\r\n17|62\r\n17|33\r\n17|65\r\n17|94\r\n17|14\r\n17|98\r\n17|55\r\n17|56\r\n17|49\r\n17|29\r\n17|58\r\n17|91\r\n17|28\r\n17|83\r\n17|69\r\n17|48\r\n92|57\r\n92|68\r\n92|93\r\n92|72\r\n92|27\r\n92|52\r\n92|74\r\n92|24\r\n92|59\r\n92|47\r\n92|77\r\n92|94\r\n92|19\r\n92|76\r\n92|17\r\n92|36\r\n92|87\r\n92|11\r\n92|26\r\n92|25\r\n92|64\r\n92|99\r\n92|82\r\n92|34\r\n93|17\r\n93|94\r\n93|28\r\n93|62\r\n93|76\r\n93|19\r\n93|26\r\n93|59\r\n93|27\r\n93|57\r\n93|25\r\n93|52\r\n93|64\r\n93|34\r\n93|68\r\n93|11\r\n93|77\r\n93|82\r\n93|72\r\n93|36\r\n93|99\r\n93|24\r\n93|47\r\n93|87\r\n28|58\r\n28|81\r\n28|15\r\n28|95\r\n28|14\r\n28|83\r\n28|56\r\n28|61\r\n28|48\r\n28|97\r\n28|23\r\n28|92\r\n28|33\r\n28|55\r\n28|98\r\n28|69\r\n28|65\r\n28|62\r\n28|91\r\n28|63\r\n28|49\r\n28|29\r\n28|75\r\n28|39\r\n25|11\r\n25|34\r\n25|81\r\n25|59\r\n25|17\r\n25|29\r\n25|62\r\n25|26\r\n25|69\r\n25|94\r\n25|68\r\n25|75\r\n25|55\r\n25|27\r\n25|28\r\n25|19\r\n25|33\r\n25|76\r\n25|15\r\n25|87\r\n25|77\r\n25|36\r\n25|57\r\n25|98\r\n47|64\r\n47|81\r\n47|15\r\n47|34\r\n47|57\r\n47|59\r\n47|24\r\n47|77\r\n47|28\r\n47|99\r\n47|68\r\n47|25\r\n47|27\r\n47|19\r\n47|76\r\n47|11\r\n47|87\r\n47|62\r\n47|82\r\n47|26\r\n47|98\r\n47|17\r\n47|36\r\n47|94\r\n81|56\r\n81|93\r\n81|92\r\n81|75\r\n81|74\r\n81|58\r\n81|29\r\n81|65\r\n81|48\r\n81|39\r\n81|49\r\n81|33\r\n81|55\r\n81|52\r\n81|14\r\n81|98\r\n81|95\r\n81|61\r\n81|91\r\n81|63\r\n81|69\r\n81|97\r\n81|23\r\n81|83\r\n68|28\r\n68|11\r\n68|33\r\n68|62\r\n68|29\r\n68|55\r\n68|34\r\n68|59\r\n68|49\r\n68|65\r\n68|69\r\n68|17\r\n68|23\r\n68|58\r\n68|63\r\n68|98\r\n68|81\r\n68|83\r\n68|26\r\n68|36\r\n68|91\r\n68|75\r\n68|15\r\n68|94\r\n69|83\r\n69|14\r\n69|56\r\n69|23\r\n69|39\r\n69|61\r\n69|49\r\n69|72\r\n69|65\r\n69|52\r\n69|58\r\n69|29\r\n69|97\r\n69|75\r\n69|63\r\n69|91\r\n69|24\r\n69|47\r\n69|95\r\n69|55\r\n69|92\r\n69|48\r\n69|93\r\n69|74\r\n11|17\r\n11|65\r\n11|33\r\n11|98\r\n11|26\r\n11|58\r\n11|29\r\n11|75\r\n11|81\r\n11|83\r\n11|69\r\n11|62\r\n11|49\r\n11|55\r\n11|91\r\n11|28\r\n11|94\r\n11|15\r\n11|34\r\n11|59\r\n11|36\r\n11|63\r\n11|23\r\n11|61\r\n29|14\r\n29|49\r\n29|47\r\n29|72\r\n29|74\r\n29|23\r\n29|55\r\n29|48\r\n29|52\r\n29|91\r\n29|92\r\n29|56\r\n29|83\r\n29|61\r\n29|39\r\n29|93\r\n29|63\r\n29|65\r\n29|75\r\n29|24\r\n29|95\r\n29|58\r\n29|97\r\n29|64\r\n64|81\r\n64|17\r\n64|57\r\n64|28\r\n64|11\r\n64|76\r\n64|26\r\n64|33\r\n64|77\r\n64|36\r\n64|98\r\n64|27\r\n64|34\r\n64|87\r\n64|62\r\n64|19\r\n64|69\r\n64|82\r\n64|59\r\n64|15\r\n64|25\r\n64|68\r\n64|94\r\n64|99\r\n61|39\r\n61|93\r\n61|56\r\n61|47\r\n61|27\r\n61|87\r\n61|99\r\n61|82\r\n61|68\r\n61|76\r\n61|48\r\n61|64\r\n61|72\r\n61|14\r\n61|19\r\n61|97\r\n61|77\r\n61|24\r\n61|92\r\n61|52\r\n61|74\r\n61|95\r\n61|57\r\n61|25\r\n58|39\r\n58|19\r\n58|24\r\n58|82\r\n58|27\r\n58|76\r\n58|14\r\n58|56\r\n58|61\r\n58|99\r\n58|93\r\n58|25\r\n58|57\r\n58|97\r\n58|47\r\n58|48\r\n58|74\r\n58|87\r\n58|92\r\n58|72\r\n58|95\r\n58|77\r\n58|52\r\n58|64\r\n55|63\r\n55|65\r\n55|95\r\n55|93\r\n55|61\r\n55|23\r\n55|97\r\n55|72\r\n55|49\r\n55|99\r\n55|74\r\n55|82\r\n55|24\r\n55|47\r\n55|64\r\n55|39\r\n55|14\r\n55|92\r\n55|56\r\n55|52\r\n55|58\r\n55|91\r\n55|48\r\n55|83\r\n49|95\r\n49|47\r\n49|99\r\n49|76\r\n49|57\r\n49|48\r\n49|77\r\n49|27\r\n49|93\r\n49|87\r\n49|56\r\n49|72\r\n49|25\r\n49|61\r\n49|97\r\n49|74\r\n49|58\r\n49|14\r\n49|52\r\n49|24\r\n49|39\r\n49|64\r\n49|92\r\n49|82\r\n26|63\r\n26|58\r\n26|14\r\n26|94\r\n26|61\r\n26|91\r\n26|65\r\n26|81\r\n26|49\r\n26|23\r\n26|83\r\n26|29\r\n26|33\r\n26|95\r\n26|55\r\n26|48\r\n26|17\r\n26|15\r\n26|56\r\n26|62\r\n26|69\r\n26|75\r\n26|98\r\n26|28\r\n39|57\r\n39|27\r\n39|25\r\n39|19\r\n39|99\r\n39|77\r\n39|17\r\n39|47\r\n39|64\r\n39|11\r\n39|52\r\n39|92\r\n39|34\r\n39|82\r\n39|36\r\n39|68\r\n39|59\r\n39|74\r\n39|24\r\n39|87\r\n39|93\r\n39|76\r\n39|72\r\n39|26\r\n57|19\r\n57|83\r\n57|65\r\n57|59\r\n57|36\r\n57|68\r\n57|94\r\n57|26\r\n57|15\r\n57|28\r\n57|81\r\n57|63\r\n57|75\r\n57|91\r\n57|62\r\n57|69\r\n57|29\r\n57|23\r\n57|17\r\n57|55\r\n57|11\r\n57|34\r\n57|33\r\n57|98\r\n23|48\r\n23|77\r\n23|14\r\n23|56\r\n23|92\r\n23|74\r\n23|58\r\n23|72\r\n23|47\r\n23|39\r\n23|25\r\n23|91\r\n23|97\r\n23|76\r\n23|99\r\n23|24\r\n23|49\r\n23|61\r\n23|64\r\n23|27\r\n23|93\r\n23|95\r\n23|82\r\n23|52\r\n76|28\r\n76|11\r\n76|69\r\n76|26\r\n76|81\r\n76|15\r\n76|57\r\n76|83\r\n76|94\r\n76|59\r\n76|33\r\n76|68\r\n76|55\r\n76|19\r\n76|36\r\n76|17\r\n76|34\r\n76|62\r\n76|65\r\n76|98\r\n76|75\r\n76|87\r\n76|63\r\n76|29\r\n33|23\r\n33|97\r\n33|93\r\n33|63\r\n33|91\r\n33|14\r\n33|39\r\n33|74\r\n33|56\r\n33|29\r\n33|72\r\n33|95\r\n33|47\r\n33|55\r\n33|58\r\n33|65\r\n33|83\r\n33|61\r\n33|92\r\n33|48\r\n33|49\r\n33|52\r\n33|69\r\n33|75\r\n36|56\r\n36|69\r\n36|91\r\n36|61\r\n36|23\r\n36|26\r\n36|15\r\n36|75\r\n36|63\r\n36|65\r\n36|49\r\n36|29\r\n36|81\r\n36|17\r\n36|94\r\n36|59\r\n36|62\r\n36|28\r\n36|58\r\n36|33\r\n36|83\r\n36|55\r\n36|98\r\n36|95\r\n62|65\r\n62|58\r\n62|49\r\n62|69\r\n62|39\r\n62|23\r\n62|83\r\n62|98\r\n62|55\r\n62|75\r\n62|63\r\n62|14\r\n62|33\r\n62|74\r\n62|95\r\n62|48\r\n62|97\r\n62|81\r\n62|91\r\n62|15\r\n62|29\r\n62|56\r\n62|92\r\n62|61\r\n65|14\r\n65|64\r\n65|58\r\n65|83\r\n65|74\r\n65|47\r\n65|23\r\n65|93\r\n65|72\r\n65|52\r\n65|48\r\n65|97\r\n65|99\r\n65|92\r\n65|95\r\n65|25\r\n65|61\r\n65|91\r\n65|39\r\n65|82\r\n65|77\r\n65|49\r\n65|56\r\n65|24\r\n56|48\r\n56|77\r\n56|52\r\n56|93\r\n56|57\r\n56|14\r\n56|74\r\n56|39\r\n56|72\r\n56|24\r\n56|99\r\n56|34\r\n56|82\r\n56|64\r\n56|25\r\n56|68\r\n56|19\r\n56|11\r\n56|92\r\n56|76\r\n56|87\r\n56|47\r\n56|97\r\n56|27\r\n48|34\r\n48|76\r\n48|27\r\n48|57\r\n48|47\r\n48|72\r\n48|77\r\n48|39\r\n48|82\r\n48|93\r\n48|52\r\n48|99\r\n48|92\r\n48|24\r\n48|97\r\n48|68\r\n48|36\r\n48|64\r\n48|19\r\n48|14\r\n48|25\r\n48|11\r\n48|87\r\n95|14\r\n95|76\r\n95|77\r\n95|48\r\n95|93\r\n95|82\r\n95|56\r\n95|19\r\n95|24\r\n95|72\r\n95|11\r\n95|92\r\n95|74\r\n95|25\r\n95|68\r\n95|27\r\n95|87\r\n95|64\r\n95|39\r\n95|47\r\n95|57\r\n95|52\r\n94|33\r\n94|91\r\n94|75\r\n94|14\r\n94|48\r\n94|58\r\n94|63\r\n94|81\r\n94|61\r\n94|39\r\n94|62\r\n94|69\r\n94|97\r\n94|28\r\n94|49\r\n94|55\r\n94|15\r\n94|65\r\n94|95\r\n94|29\r\n94|83\r\n19|91\r\n19|26\r\n19|55\r\n19|81\r\n19|36\r\n19|23\r\n19|65\r\n19|94\r\n19|63\r\n19|17\r\n19|59\r\n19|69\r\n19|33\r\n19|68\r\n19|11\r\n19|49\r\n19|28\r\n19|34\r\n19|15\r\n19|29\r\n83|77\r\n83|95\r\n83|47\r\n83|27\r\n83|39\r\n83|56\r\n83|64\r\n83|23\r\n83|72\r\n83|48\r\n83|82\r\n83|25\r\n83|74\r\n83|97\r\n83|14\r\n83|99\r\n83|52\r\n83|24\r\n83|91\r\n75|56\r\n75|61\r\n75|63\r\n75|52\r\n75|49\r\n75|55\r\n75|91\r\n75|74\r\n75|65\r\n75|97\r\n75|92\r\n75|48\r\n75|23\r\n75|95\r\n75|99\r\n75|72\r\n75|93\r\n75|47\r\n59|15\r\n59|33\r\n59|28\r\n59|49\r\n59|81\r\n59|91\r\n59|17\r\n59|58\r\n59|61\r\n59|62\r\n59|26\r\n59|75\r\n59|63\r\n59|56\r\n59|83\r\n59|29\r\n59|48\r\n77|75\r\n77|33\r\n77|63\r\n77|81\r\n77|19\r\n77|55\r\n77|27\r\n77|98\r\n77|17\r\n77|36\r\n77|87\r\n77|59\r\n77|94\r\n77|69\r\n77|29\r\n77|68\r\n72|59\r\n72|94\r\n72|99\r\n72|77\r\n72|11\r\n72|68\r\n72|36\r\n72|24\r\n72|62\r\n72|25\r\n72|82\r\n72|15\r\n72|17\r\n72|64\r\n72|27\r\n87|19\r\n87|83\r\n87|68\r\n87|98\r\n87|59\r\n87|81\r\n87|34\r\n87|28\r\n87|55\r\n87|36\r\n87|26\r\n87|62\r\n87|75\r\n87|15\r\n99|17\r\n99|15\r\n99|26\r\n99|36\r\n99|33\r\n99|98\r\n99|25\r\n99|87\r\n99|57\r\n99|82\r\n99|59\r\n99|11\r\n99|62\r\n98|75\r\n98|56\r\n98|33\r\n98|93\r\n98|49\r\n98|95\r\n98|29\r\n98|65\r\n98|52\r\n98|48\r\n98|83\r\n98|58\r\n14|77\r\n14|24\r\n14|97\r\n14|92\r\n14|52\r\n14|57\r\n14|59\r\n14|72\r\n14|82\r\n14|47\r\n14|74\r\n27|28\r\n27|75\r\n27|63\r\n27|59\r\n27|34\r\n27|81\r\n27|62\r\n27|33\r\n27|11\r\n27|15\r\n97|47\r\n97|77\r\n97|68\r\n97|93\r\n97|76\r\n97|92\r\n97|19\r\n97|26\r\n97|34\r\n82|15\r\n82|26\r\n82|33\r\n82|27\r\n82|17\r\n82|98\r\n82|59\r\n82|75\r\n63|82\r\n63|97\r\n63|49\r\n63|24\r\n63|23\r\n63|99\r\n63|74\r\n24|25\r\n24|94\r\n24|26\r\n24|64\r\n24|87\r\n24|62\r\n15|39\r\n15|97\r\n15|56\r\n15|98\r\n15|93\r\n52|15\r\n52|99\r\n52|17\r\n52|77\r\n91|49\r\n91|74\r\n91|27\r\n74|64\r\n74|99\r\n34|26";
    //string inputInstructions = "75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47";
    string inputInstructions = "62,15,81,98,69,29,75,63,65,83,91,58,61,95,48,14,97,39,92\r\n83,23,49,58,61,95,48,97,39,92,47,25,77\r\n27,26,19,69,94,34,99,87,25\r\n47,14,27,24,77,19,76,34,72,57,36,74,97,99,93,82,52,68,87,64,25\r\n64,99,25,77,27,87,57,19,68,11,34,36,26,17,94,62,81,98,33\r\n28,62,15,98,33,69,29,75,55,83,91,49,58,95,56,14,97\r\n63,23,39,69,61,65,49\r\n82,25,77,27,76,87,57,19,68,11,34,36,26,17,94,28,15,81,33,69,29\r\n58,49,63,91,29,98,83,55,36,69,15,33,26,65,17,94,34,59,75,61,28,23,62\r\n97,47,58,61,24,93,95,56,25,92,72,64,74,14,39,23,99,83,48\r\n28,91,55,75,81,23,58,33,59,36,29,62,83,98,65,11,63,94,49,34,26,15,69\r\n93,52,47,24,99,77,27,76,87,57,68,11,59,26,28\r\n47,64,25,77,27,76,87,11,34,26,17\r\n74,52,24,27,34,26,94\r\n25,17,19,76,15,59,26,57,27,69,81,94,62,36,99,98,28,87,11,77,68,33,34\r\n91,49,58,61,95,56,14,97,39,92,74,93,52,72,47,24,64,99,82,25,77,27,76\r\n99,25,77,87,57,19,68,11,34,36,59,26,17,94,28,62,15,81,98,33,69\r\n24,64,99,82,25,77,76,87,57,19,68,11,34,36,59,26,17,94,28,62,15,81,98\r\n47,26,15,64,82,25,59,17,34,28,87,11,99,57,19,27,24,62,68\r\n58,56,39,72,24,77,27,87,57\r\n26,23,17,63,75,81,59\r\n52,39,77,24,72,27,47,97,82,93,14,23,92\r\n93,52,61,69,75,39,98\r\n65,49,58,39,74,92,56,82,72\r\n58,95,56,48,14,74,93,52,47,24,64,99,77,27,57\r\n92,93,49,72,48,58,91,75,65,14,74,39,63,83,61,29,55,23,97\r\n74,64,82,19,87,57,24,56,76,52,93,27,25,92,72\r\n19,72,56,99,87,48,76,27,92,77,95,52,68\r\n57,34,94,98,55\r\n76,87,19,68,11,34,36,59,62,81,69,75,55,63,65\r\n48,99,64,92,39,74,49,93,47,24,14,52,72,87,82,58,27\r\n68,81,29,65,83,23,49\r\n49,56,62,98,61,69,59,63,23,29,83,81,65,26,17\r\n29,28,49,11,63,26,94\r\n63,14,92,24,64,99,82\r\n64,76,25,72,87,27,97,99,52,34,82,92,68\r\n58,81,33,91,75,63,74,93,65\r\n25,87,19,11,34,59,33,29,75\r\n17,25,59,11,99,57,36\r\n62,15,98,33,69,29,75,63,83,23,91,49,58,95,56,48,97\r\n97,92,93,52,72,47,24,64,99,25,77,76,87,57,19,34,59\r\n52,72,47,82,25,27,76,87,68,11,36,59,94,28,62\r\n29,59,87,76,36,68,94,28,33,27,77\r\n92,93,77,27,57,68,11\r\n93,64,39,92,63,72,82,48,14,65,52,58,24\r\n72,47,11,34,59,94,15\r\n33,55,65,49,56,48,14,97,92,74,72\r\n17,69,83,34,62,49,63,15,59,94,11,28,33,58,55,23,81\r\n34,61,26,59,91,23,49\r\n19,68,34,94,81,33,23\r\n52,24,99,82,25,87,57,59,62\r\n48,14,97,39,92,74,93,52,24,99,82,25,27,87,57,19,68,11,34\r\n55,64,39,95,49,24,65,75,23\r\n63,83,61,93,52,24,82\r\n62,33,14,48,81,95,15,75,63,69,49,56,65,97,61,23,29,28,58,91,39\r\n97,39,52,25,27\r\n33,36,28,17,25,62,81,76,27,19,64\r\n97,15,98,33,91,65,56,29,74\r\n29,63,65,47,69,39,49\r\n36,59,17,94,62,81,98,55,63,83,23,91,58\r\n95,52,76,14,99,19,48,39,92,82,24,57,74\r\n64,25,76,68,34,36,59,15,33\r\n64,39,47,92,87,93,82,24,72,74,48,97,27,14,19,25,11,52,56\r\n39,92,74,93,52,72,47,24,99,82,25,77,27,76,87,57,19,68,11,34,36,59,26\r\n94,28,62,15,81,98,33,69,29,75,55,63,83,23,91,49,58,61,95,48,97\r\n69,63,34,58,33,49,29,75,81,23,26,94,15,65,28,59,17,98,83,61,36\r\n49,58,95,56,48,14,97,74,93,52,47,24,64,99,25,77,27,76,87\r\n97,92,74,93,52,72,24,64,99,82,25,77,27,76,87,19,68,11,34,36,59\r\n56,48,99,91,47,39,23,65,92,64,93,74,49,24,61,58,52,83,97,72,82,14,95\r\n47,99,82,25,11,34,26,17,62,15,81\r\n93,82,24,39,64,74,27,97,48,72,56,61,19\r\n39,52,25,77,76,19,34,36,26\r\n99,76,87,57,19,68,28,62,69\r\n76,62,99,82,59,11,27,98,17,57,68,87,77,81,36,19,15,94,34,25,26\r\n14,33,93,58,49,48,69,63,91,56,29,65,83,39,74,23,61,55,95\r\n95,48,61,55,75,47,49,56,69\r\n65,17,59,56,75,55,83,62,15,29,98\r\n17,94,81,98,33,75,55,63,23,58,61\r\n48,25,58,24,74,92,49,97,99,14,39,77,64,52,56,61,76,95,91,72,27\r\n58,29,14,52,95,48,65,75,49,98,69,63,23\r\n19,68,34,36,94,81,65,83,91\r\n72,47,24,64,25,27,76,87,57,68,11,36,59,26,94,62,15\r\n19,34,59,98,69,75,55,83,91\r\n62,98,29,55,63,65,83,49,58,56,39\r\n47,72,24,95,93,83,56,91,52,64,77\r\n36,26,94,15,81,98,33,29,75,63,65,83,23,91,49,61,95\r\n65,83,23,58,48,97,39,74,72,99,82\r\n39,34,27,25,47,93,72,92,99,11,74,19,76,24,97,77,57,14,64,48,68,82,52\r\n75,55,23,91,58,61,56,48,14,97,93,52,72,24,64\r\n24,27,26,82,93,34,99,72,92,59,74,57,39,76,11,47,36\r\n64,25,77,76,87,11,36,17,94,28,62,15,81,98,33\r\n33,28,87,81,83,36,19,63,62,55,68,75,17,15,34,26,94,57,59\r\n27,76,87,57,19,68,11,34,36,59,26,17,94,28,62,15,81,98,33,69,75,55,63\r\n76,11,36,59,17,94,15,98,65\r\n62,57,68,98,11,81,33,59,63,26,19,15,27,29,76\r\n55,63,65,83,23,91,49,58,48,14,97,92,93,52,72,47,99\r\n23,52,29,48,39,14,91,93,58,49,61,63,72,74,69,95,65,55,56\r\n68,87,48,25,95,19,56\r\n52,72,47,24,64,99,82,25,27,57,34,59,17,94,62\r\n95,74,25,56,48,87,64,99,47,93,27,52,97,14,77,57,24\r\n27,87,57,11,34,26,94,28,15,98,33,69,29,75,63\r\n59,17,94,81,98,69,55,65,23,91,61,95,56\r\n74,93,36,57,14,34,87\r\n25,77,76,87,57,19,68,11,36,59,26,17,94,28,81,98,33,69,75\r\n97,75,39,14,24,56,95,63,65,48,64,23,83,74,61\r\n26,94,28,62,81,98,33,29,75,55,63,83,91,61,95\r\n75,55,63,58,29,62,23,91,95,49,65,48,92,15,81\r\n33,69,29,75,55,63,65,83,23,49,58,61,95,56,48,14,97,39,92,74,93,52,72\r\n17,56,81,94,91,15,14,62,23\r\n97,52,72,47,82,27,87,57,34,36,59\r\n69,55,63,83,23,58,61,56,14,39,92,74,93\r\n69,68,55,33,63,94,27,75,34,81,87,28,15,19,36,17,57\r\n39,92,74,87,25,77,36,72,57,76,64,68,26,93,34,47,99\r\n24,76,26,52,34,19,47,94,59,25,68,11,93,99,87,82,36,17,64,57,27,74,72\r\n48,24,99,82,25,77,57,11,34\r\n15,29,75,65,61,48,92\r\n77,76,75,87,28,94,27,59,57,33,55,81,17,11,29,19,36\r\n76,87,19,68,11,34,36,59,26,94,28,62,15,81,98,33,69,29,75,55,65\r\n26,19,87,47,17\r\n63,65,83,23,91,49,58,61,95,56,48,14,97,39,92,74,93,52,72,47,64,99,82\r\n61,25,92,52,58,39,47,97,82,72,56,77,64,74,24,14,93,91,23,27,48,99,95\r\n65,63,15,75,49,81,23,17,68,83,33,36,69,28,94,98,62,91,26,29,59\r\n91,98,69,97,63,58,49,83,65,61,48,56,23,29,95,52,74\r\n28,63,61,94,75,97,55,49,23,15,83,62,58,48,69,65,95,98,91\r\n99,87,17,74,26,25,92,11,57,59,64,77,72,24,76,93,47,19,52,82,27,36,34\r\n55,65,49,48,97,74,52,47,99\r\n26,17,28,62,15,81,98,33,69,29,75,55,63,65,83,23,91,49,58,61,95,56,48\r\n11,26,87,47,57,64,72,92,34\r\n47,24,64,99,82,77,76,57,68,11,34,59,26,94,62\r\n61,65,28,75,91,97,62,29,58,56,83,48,81,39,69,95,98\r\n57,76,75,69,11,77,87,33,62,94,98,26,25,15,36,59,27,28,81,34,19\r\n99,82,25,77,27,76,87,57,19,68,11,34,36,59,26,17,94,28,62,15,81,33,69\r\n55,83,23,91,58,61,48,14,39,92,93,47,24,64,99\r\n62,15,81,98,69,29,75,55,63,65,83,91,49,58,95,56,14,39,92\r\n52,64,99,48,82,92,47,97,61,58,76,24,25\r\n94,28,15,81,33,69,29,65,83,23,49,58,61,14,97\r\n97,24,14,23,58,39,82,92,74,52,61,64,65,91,83\r\n77,27,19,34,15,81,55\r\n95,65,83,28,59,98,36,55,91,62,81,33,17,29,94,75,69,23,58\r\n68,17,94,28,62,15,81,33,69,75,55,63,49\r\n28,76,33,64,99,34,94\r\n94,75,26,11,29,34,27,59,76,55,63,36,68,69,62\r\n63,65,83,23,91,49,58,61,95,56,48,14,39,92,74,93,52,72,47,24,64,99,82\r\n24,68,92,95,19,72,57,64,56,93,52,97,48,74,27,99,87,77,76\r\n52,24,25,27,76,87,19,68,11,59,26,94,62\r\n59,47,64,57,99,87,25,68,19,24,92,39,82,97,34\r\n83,23,91,49,58,61,95,56,48,14,97,39,92,74,93,52,72,47,24,64,99,82,25\r\n58,95,56,14,93,52,72,99,27,87,57\r\n29,55,65,83,23,91,49,58,61,95,48,14,97,39,92,93,52,72,24\r\n91,49,56,97,92,93,82,77,76\r\n77,82,68,25,81\r\n81,69,75,55,63,65,83,23,91,61,56,14,97,74,93\r\n93,29,58,92,24,61,95,72,91,97,23,56,55,14,65\r\n25,92,36,34,72,39,26\r\n99,34,82,57,52,59,19,25,72,93,74,64,47,36,24,97,68,87,39,11,27,77,92\r\n64,27,76,19,36,59,26,94,33\r\n25,64,87,52,72,97,77,92,57,48,34\r\n98,33,69,29,75,55,63,65,83,23,91,49,58,61,56,48,97,39,92,93,52\r\n59,23,91,49,58\r\n11,36,94,28,69,55,65,23,91\r\n26,28,15,81,33,69,29,55,63,65,23,91,49,58,95,56,48\r\n25,36,93,77,68,64,99,92,57,19,14,74,82\r\n87,26,59,83,98,65,81,69,62\r\n27,17,75,11,59,55,34,68,26,33,63,19,29,69,36,28,94,87,15,81,98,62,76\r\n83,11,91,58,26,34,69\r\n52,47,24,64,25,77,59,28,62\r\n75,55,65,83,49,61,92,74,72\r\n93,19,48,34,25,47,64\r\n14,97,39,57,68,34,36\r\n91,62,26,98,49,61,15,17,69,81,23,83,48,56,95,63,94,28,55,58,75\r\n61,99,52,74,39,93,25,72,91,58,92,23,82,48,47,56,14\r\n68,26,99,15,64\r\n69,94,91,48,63,98,75,23,62,26,61,55,65,83,15,56,95\r\n26,17,94,28,62,15,81,98,75,55,65,83,23,91,58,61,95,56,48\r\n47,64,58,97,91,14,49,72,52,25,92,24,23,61,93,95,56,99,27,48,77\r\n28,58,49,81,75,11,15,55,59\r\n81,33,93,91,48,98,75,61,58\r\n29,81,75,65,63,58,61,15,62,95,39,92,55,56,49,23,48,91,97,83,69,33,14\r\n81,98,33,29,75,65,23,95,56,48,97,39,92,74,93\r\n63,61,55,58,74,72,52,48,65,69,29,23,91,95,92,97,47\r\n65,81,17,49,69\r\n92,74,93,52,72,47,24,99,77,76,19,34,36\r\n92,55,23,39,47,56,72,24,75,93,91,83,52,14,63,74,29\r\n91,72,56,64,95,47,75\r\n17,94,27,99,24,82,68,47,64,62,28,77,59,26,36,76,87,34,57\r\n14,97,92,74,93,47,24,82,77,57,11,34,36\r\n81,15,76,87,33,28,94,98,75,27,68,55,36,62,77,11,29,69,34\r\n97,83,23,29,55,58,75,52,91,56,72,61,65,24,74,48,93,92,63\r\n76,87,57,19,68,11,34,36,59,17,94,28,62,15,81,98,33,69,29,75,55,63,65\r\n61,95,56,14,39,72,47,24,25,77,87,57,19\r\n15,23,81,63,59,34,61,91,28,29,65,83,17,55,75,62,98,94,26,33,58,69,49\r\n82,25,77,27,76,87,57,19,68,11,34,36,59,17,94,28,62,15,81,98,33,69,29\r\n95,56,48,39,92,93,52,72,47,24,64,82,25,27,76,87,57,19,68\r\n49,58,92,93,24,64,82,76,87\r\n49,72,74,93,24,48,99\r\n59,26,17,94,28,62,15,81,98,33,69,29,75,55,63,65,83,23,91,49,56\r\n58,15,59,33,65,23,17,95,94,49,28,91,62,69,98\r\n17,94,28,62,33,69,23,58,56\r\n59,94,15,98,29,75,23,91,49,58,61,95,56\r\n34,28,15,76,98,24,57,26,87\r\n82,27,15,17,64,34,87,57,68,72,24,77,25,19,94,47,36,62,26,59,28,11,99\r\n93,48,64,14,75,58,97,49,55\r\n69,55,63,23,91,49,92,72,47\r\n34,19,36,68,99,69,27,28,81,59,62,87,82\r\n48,92,52,24,64,99,82,77,76,87,57,11,34\r\n23,75,91,15,63,55,33,48,61,98,74\r\n24,76,77,99,27,25,14,92,47,95,87,64,52,56,39,72,49\r\n64,99,82,25,77,27,76,87,57,19,68,11,34,36,59,26,17,94,28,62,15,81,98";

    List<(int, int)> ConvertPairsToList(string input)
    {
        string[] lines = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        List<(int, int)> tupleList = [];

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            int first = int.Parse(parts[0]);
            int second = int.Parse(parts[1]);

            // Add the tuple to the list
            tupleList.Add((first, second));
        }
        return tupleList;
    }


    List<List<int>> ConvertInstructionsToList(string input)
    {
        string[] lines = inputInstructions.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        List<List<int>> listOfLists = new List<List<int>>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            List<int> intList = [];
            foreach (string part in parts)
            {
                intList.Add(int.Parse(part));
            }

            listOfLists.Add(intList);
        }
        return listOfLists;
    }

    /*
    var pairs = ConvertPairsToList(inputPairs);
    var instructions = ConvertInstructionsToList(inputInstructions);
    */

    // END INPUT

    // Part 1

    int Count(List<List<int>> list, int acc = 0)
    {
        return list switch
        {
        [] => acc,
        [var x, .. var xs] => Count(xs, acc + x[(x.Count / 2)])
        };
    }

    List<List<int>> ValidInstructions(Span<List<int>> l, List<(int, int)> pairs)
    {
        var graph = ToGraph(pairs);
        List<List<int>> valid = [];

        foreach (var i in l)
        {
            bool IsValid = true;
            for (int j = 0; j < i.Count; j++)
            {
                if (graph[i[j]].Count > 0 && graph[i[j]].Any(x => i[j..].Contains(x)))  // invalid instruction
                {
                    IsValid = false;
                    break;
                }
            }
            if (IsValid) valid.Add(i);
        }
        return valid;
    }

    Dictionary<int, List<int>> ToGraph(List<(int, int)> pairs)
    {
        var graph = new Dictionary<int, List<int>>(); //adjency lst

        foreach (var (a, b) in pairs)
        {
            if (!graph.ContainsKey(a)) graph[a] = new List<int>();
            if (!graph.ContainsKey(b)) graph[b] = new List<int>();

            graph[b].Add(a);
        }

        return graph;
    }


    //var test = ValidInstructions([.. instructions], pairs);
    //Console.WriteLine($"Number: {Count(test)}");

    // Part 2
    // Find invalids
    List<List<int>> InvalidInstructions(Span<List<int>> l, List<(int, int)> pairs)
    {
        var graph = ToGraph(pairs);
        List<List<int>> valid = [];

        foreach (var i in l)
        {
            for (int j = 0; j < i.Count; j++)
            {
                if (graph[i[j]].Count > 0 && graph[i[j]].Any(x => i[j..].Contains(x)))  // invalid instruction
                {
                    valid.Add(i);
                    break;
                }
            }
        }
        return valid;
    }


    List<List<int>> RebalancedSolutions(List<List<int>> l, List<(int, int)> pairs)
    {
        var graph = ToGraph(pairs);
        List<List<int>> valid = [];

        foreach (var i in l)
        {
            bool recheck = true;
            while (recheck)
            {
                recheck = false;
                for (int j = 0; j < i.Count; j++)
                {
                    int violation = graph[i[j]].FirstOrDefault(x => i[j..].Contains(x));
                    if (violation != 0)
                    {
                        var index = i.IndexOf(violation);
                        int tmp = i[j];
                        i[j] = violation;
                        i[index] = tmp;

                        recheck = true;
                        break;
                    }
                }
            }
            valid.Add(i);
        }

        return valid;
    }

    /*
    var test2 = InvalidInstructions([.. instructions], pairs);
    var rebelanced = RebalancedSolutions(test2, pairs);
    Console.WriteLine($"Number: {Count(rebelanced)}");
    */

}
