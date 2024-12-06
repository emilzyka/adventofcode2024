﻿namespace AdventCode2024.Days;

public class Day2
{
    // INPUT READING: 
    string input = "66 67 68 71 72 69\r\n72 75 78 79 79\r\n38 40 41 42 44 47 48 52\r\n86 87 88 91 96\r\n30 33 34 36 39 36 38 40\r\n77 78 79 80 79 76\r\n84 87 89 86 87 87\r\n7 10 13 14 16 19 18 22\r\n22 25 28 26 28 29 32 38\r\n47 50 53 53 54 56 57 60\r\n67 69 71 73 73 72\r\n15 16 16 19 21 23 23\r\n87 88 90 92 92 96\r\n20 21 24 24 29\r\n18 20 22 24 28 29 31 33\r\n86 87 88 91 95 97 96\r\n13 16 19 22 26 26\r\n28 31 35 38 42\r\n35 37 41 44 49\r\n33 36 42 45 46\r\n78 81 82 85 90 87\r\n44 47 49 54 55 57 57\r\n50 52 53 58 62\r\n72 75 80 81 82 89\r\n12 10 12 14 15 16 19 22\r\n40 39 41 42 45 47 49 46\r\n23 21 24 27 29 30 30\r\n11 8 11 14 15 18 19 23\r\n21 19 22 23 26 27 34\r\n62 61 58 59 60\r\n52 50 53 52 50\r\n3 1 2 5 7 4 4\r\n68 65 68 67 68 72\r\n45 42 40 43 49\r\n5 4 7 9 11 11 14 17\r\n7 4 5 7 10 10 7\r\n64 62 64 64 66 67 67\r\n87 86 86 88 91 92 96\r\n64 62 62 63 64 65 68 73\r\n64 61 62 63 67 68\r\n12 9 13 15 13\r\n83 81 84 88 90 93 95 95\r\n6 3 5 9 10 12 16\r\n38 35 39 41 47\r\n62 60 63 70 71 74\r\n56 55 60 61 63 64 62\r\n44 43 44 45 47 53 53\r\n61 60 67 69 73\r\n73 70 73 74 77 82 84 89\r\n8 8 10 11 14 17\r\n55 55 56 57 59 56\r\n75 75 76 79 81 82 84 84\r\n72 72 75 78 80 84\r\n69 69 72 75 76 77 82\r\n49 49 51 49 51\r\n38 38 41 44 45 43 42\r\n15 15 17 16 16\r\n25 25 26 24 25 26 29 33\r\n18 18 20 22 21 22 29\r\n81 81 81 83 84 85 86\r\n86 86 86 89 92 89\r\n27 27 30 31 32 32 35 35\r\n33 33 33 34 37 40 42 46\r\n50 50 50 52 53 56 58 65\r\n65 65 66 70 73\r\n65 65 66 67 71 70\r\n8 8 9 12 14 18 18\r\n70 70 73 77 81\r\n65 65 66 68 69 73 79\r\n25 25 28 35 36\r\n41 41 48 51 53 56 55\r\n87 87 88 95 95\r\n70 70 75 76 79 81 83 87\r\n10 10 12 13 18 23\r\n69 73 75 77 78 81 83 86\r\n62 66 68 70 72 71\r\n81 85 88 89 92 92\r\n33 37 39 42 45 49\r\n49 53 56 57 58 60 67\r\n18 22 20 21 24 26\r\n80 84 87 90 88 85\r\n17 21 22 21 22 25 25\r\n29 33 35 34 38\r\n5 9 6 7 9 16\r\n19 23 26 29 29 32\r\n49 53 56 57 60 61 61 60\r\n63 67 69 71 71 73 76 76\r\n77 81 83 83 85 89\r\n23 27 27 30 36\r\n37 41 43 45 48 49 53 55\r\n23 27 31 32 35 32\r\n52 56 58 62 62\r\n15 19 23 26 30\r\n60 64 66 67 70 74 76 82\r\n61 65 66 72 74 76\r\n5 9 10 17 16\r\n36 40 41 47 50 53 53\r\n30 34 35 40 41 45\r\n28 32 35 37 43 46 51\r\n22 29 31 34 37\r\n30 36 37 39 38\r\n24 31 34 37 37\r\n4 11 13 16 19 23\r\n37 43 44 45 48 50 55\r\n34 40 37 38 40 42 44\r\n11 17 18 19 21 19 20 18\r\n53 59 61 59 61 62 64 64\r\n58 65 68 65 67 69 73\r\n79 86 89 88 89 92 94 99\r\n15 20 21 22 22 23 25 27\r\n28 33 36 36 38 37\r\n88 95 97 97 99 99\r\n34 39 41 44 45 48 48 52\r\n6 11 11 12 14 16 17 22\r\n59 65 69 72 73 76\r\n54 61 63 67 69 72 74 71\r\n22 29 30 32 34 37 41 41\r\n61 68 70 74 78\r\n28 33 37 39 40 47\r\n13 19 21 24 30 32\r\n69 76 78 80 82 84 89 86\r\n8 15 18 20 25 26 26\r\n67 74 77 82 86\r\n13 18 19 25 27 30 37\r\n67 64 62 60 57 55 53 55\r\n70 69 66 63 60 58 55 55\r\n48 45 43 42 41 37\r\n62 60 59 58 53\r\n15 14 13 12 14 13 10 8\r\n29 27 29 28 25 28\r\n71 69 66 64 65 62 62\r\n17 15 13 15 12 10 6\r\n97 96 97 95 94 92 86\r\n33 30 27 24 21 18 18 17\r\n24 21 20 19 16 16 14 15\r\n43 40 40 38 36 35 35\r\n59 58 55 52 52 49 45\r\n14 12 12 11 5\r\n94 91 89 87 83 82 79\r\n21 18 16 12 10 11\r\n69 66 64 62 58 55 55\r\n88 86 83 82 79 78 74 70\r\n56 54 50 47 40\r\n21 18 13 11 8 5\r\n31 28 26 25 23 20 14 17\r\n52 50 49 43 40 39 39\r\n37 34 31 25 23 19\r\n35 32 30 24 22 21 16\r\n65 68 65 63 61 60 58 55\r\n55 56 53 52 49 52\r\n9 12 11 9 8 5 5\r\n35 36 33 32 31 29 25\r\n62 65 62 59 56 55 50\r\n77 79 82 81 79\r\n65 68 67 65 68 69\r\n26 29 28 31 30 29 29\r\n93 95 94 95 91\r\n81 84 85 83 76\r\n34 37 37 34 31 29 28 25\r\n38 40 39 36 33 33 30 33\r\n54 57 54 51 48 48 48\r\n44 47 47 44 40\r\n88 91 91 89 84\r\n48 50 48 47 44 40 39 37\r\n86 89 85 84 82 79 76 77\r\n80 82 78 76 73 70 70\r\n87 89 86 82 79 77 73\r\n45 47 43 42 41 39 37 32\r\n39 40 35 33 32 31\r\n52 53 50 43 40 42\r\n36 38 37 36 31 29 29\r\n76 79 73 72 71 68 64\r\n87 88 86 85 78 76 73 68\r\n39 39 36 33 31\r\n36 36 35 33 31 29 30\r\n88 88 86 85 82 82\r\n9 9 6 5 1\r\n99 99 97 94 92 90 88 81\r\n62 62 59 60 57 56\r\n41 41 40 37 34 36 34 36\r\n90 90 88 85 88 85 83 83\r\n59 59 60 59 56 53 49\r\n89 89 92 89 87 82\r\n72 72 72 70 68\r\n20 20 18 18 20\r\n48 48 47 46 44 44 44\r\n26 26 24 22 22 18\r\n94 94 94 93 92 91 89 82\r\n25 25 24 20 17 16 15\r\n64 64 61 58 55 51 50 53\r\n85 85 81 80 79 76 76\r\n56 56 52 49 45\r\n91 91 90 86 80\r\n58 58 56 49 48\r\n86 86 79 78 76 74 77\r\n80 80 79 76 75 72 65 65\r\n36 36 29 28 27 26 25 21\r\n22 22 17 16 9\r\n18 14 11 9 6\r\n59 55 53 50 47 50\r\n43 39 38 35 34 32 30 30\r\n37 33 32 31 29 26 22\r\n46 42 39 37 35 34 27\r\n91 87 90 89 88 85 83\r\n53 49 48 49 48 46 48\r\n95 91 90 87 89 86 86\r\n25 21 19 17 18 17 13\r\n65 61 59 61 60 53\r\n58 54 54 53 52 50\r\n58 54 54 51 52\r\n37 33 33 32 29 29\r\n71 67 65 63 62 62 58\r\n62 58 56 55 55 53 51 46\r\n23 19 16 15 12 8 5\r\n76 72 68 67 70\r\n48 44 40 38 35 35\r\n87 83 81 77 75 74 70\r\n66 62 59 55 49\r\n20 16 13 8 6 4 1\r\n56 52 51 49 42 44\r\n31 27 22 20 19 18 18\r\n30 26 24 19 17 16 12\r\n30 26 23 20 15 14 12 5\r\n51 45 42 40 38\r\n34 29 27 24 25\r\n51 44 43 42 42\r\n33 26 24 22 18\r\n82 76 74 73 67\r\n61 54 55 52 51 50\r\n74 68 66 69 72\r\n14 7 8 7 7\r\n62 56 55 57 55 52 48\r\n50 45 42 44 37\r\n19 12 12 9 7 6\r\n39 34 34 31 29 30\r\n65 58 55 53 51 51 51\r\n84 79 77 75 75 71\r\n84 79 78 75 75 73 67\r\n43 37 36 32 31 28 25 23\r\n77 70 66 63 61 58 60\r\n48 43 39 37 37\r\n78 72 68 67 64 61 57\r\n25 18 14 12 5\r\n71 66 65 58 55 53\r\n90 84 82 81 76 75 74 77\r\n54 47 46 41 41\r\n41 35 33 28 24\r\n78 73 72 71 64 62 56\r\n10 11 12 13 15 16 14\r\n49 50 51 53 56 58 60 60\r\n20 21 22 25 27 30 34\r\n70 71 74 77 78 80 86\r\n44 45 48 45 46 48 50 53\r\n62 64 65 68 71 73 70 69\r\n73 75 76 79 82 81 81\r\n34 35 32 35 39\r\n75 76 78 80 78 80 85\r\n91 92 95 95 98\r\n22 25 25 26 27 29 31 28\r\n27 30 31 31 34 36 39 39\r\n55 56 56 58 62\r\n25 28 28 31 34 39\r\n57 60 63 64 68 70 72 73\r\n60 62 65 69 72 70\r\n46 47 48 52 54 54\r\n19 22 23 25 29 33\r\n83 84 86 90 91 93 98\r\n41 42 44 49 52 55 56 57\r\n16 19 21 24 27 34 37 36\r\n27 29 32 35 38 43 43\r\n30 31 33 40 43 47\r\n39 40 41 47 48 49 56\r\n83 81 83 85 86 89 91\r\n48 46 49 52 54 55 53\r\n73 71 73 74 75 78 78\r\n71 70 71 73 74 77 79 83\r\n39 36 38 41 42 44 45 52\r\n86 85 86 84 86 87 89 91\r\n44 42 45 48 46 45\r\n86 85 86 89 87 87\r\n4 1 2 1 5\r\n46 45 44 46 47 50 56\r\n89 86 86 89 90 91\r\n73 71 72 75 76 77 77 76\r\n24 22 23 23 25 27 27\r\n29 28 29 29 33\r\n69 66 69 69 71 73 76 83\r\n61 59 63 65 67\r\n67 66 70 71 69\r\n53 50 53 57 59 60 60\r\n72 70 72 76 80\r\n38 35 38 42 49\r\n50 48 51 58 61\r\n70 68 70 76 73\r\n61 60 61 67 69 69\r\n30 27 29 31 33 38 42\r\n4 1 2 5 8 14 16 23\r\n12 12 15 16 19 21\r\n37 37 39 40 38\r\n2 2 5 7 9 10 11 11\r\n3 3 6 7 11\r\n18 18 20 23 30\r\n70 70 72 73 70 73 75\r\n38 38 40 37 39 42 43 42\r\n71 71 74 73 73\r\n65 65 64 67 68 71 75\r\n35 35 36 37 36 43\r\n30 30 31 31 32 35\r\n93 93 95 95 96 94\r\n27 27 27 30 32 33 36 36\r\n36 36 36 38 40 44\r\n18 18 20 21 22 25 25 30\r\n62 62 64 68 70 73\r\n90 90 94 95 96 99 97\r\n44 44 48 49 51 51\r\n68 68 69 73 75 79\r\n60 60 64 66 72\r\n20 20 22 24 31 33 36 37\r\n34 34 37 43 45 43\r\n58 58 63 64 67 67\r\n54 54 60 61 64 67 71\r\n67 67 68 70 77 80 86\r\n75 79 81 84 87 89\r\n45 49 51 53 50\r\n5 9 12 15 17 19 19\r\n47 51 54 55 56 60\r\n76 80 81 83 86 89 90 97\r\n83 87 89 88 91 92\r\n29 33 31 34 31\r\n51 55 57 60 57 59 59\r\n35 39 40 39 40 44\r\n1 5 8 5 8 13\r\n74 78 79 79 80\r\n57 61 61 62 65 63\r\n4 8 8 10 10\r\n67 71 74 74 77 81\r\n42 46 47 50 50 55\r\n36 40 41 45 47\r\n53 57 60 64 67 64\r\n6 10 11 13 17 17\r\n78 82 84 88 90 94\r\n79 83 86 89 93 98\r\n34 38 45 46 49 52\r\n50 54 59 62 64 66 65\r\n58 62 69 71 72 72\r\n56 60 65 66 67 71\r\n22 26 28 30 32 37 38 44\r\n84 89 91 93 94 95\r\n58 63 64 67 65\r\n36 41 44 47 50 52 55 55\r\n62 67 68 69 73\r\n70 77 80 81 84 86 92\r\n68 73 74 71 72 75 78 81\r\n73 79 76 79 76\r\n53 58 55 56 57 58 59 59\r\n31 36 34 37 40 44\r\n37 43 41 43 50\r\n14 20 22 22 25\r\n70 75 77 80 80 81 84 83\r\n51 56 59 59 59\r\n2 8 9 12 12 14 16 20\r\n50 55 57 58 60 60 65\r\n58 63 64 66 70 72\r\n81 88 90 93 97 95\r\n26 33 37 39 41 41\r\n74 80 82 86 90\r\n26 33 37 38 44\r\n68 75 81 82 83 84\r\n13 18 19 21 26 27 29 27\r\n53 59 60 66 69 70 70\r\n17 22 29 30 33 35 38 42\r\n42 47 48 49 50 52 58 65\r\n84 83 81 79 76 78\r\n61 58 55 54 54\r\n77 75 73 70 67 63\r\n86 85 84 83 80 77 76 70\r\n44 41 42 39 38 37 35\r\n22 19 16 13 16 13 11 14\r\n86 85 84 87 86 86\r\n32 31 30 29 31 28 24\r\n18 15 12 9 7 9 7 1\r\n84 81 81 78 76 74\r\n11 10 7 6 6 4 3 5\r\n20 19 19 18 18\r\n16 13 13 10 6\r\n99 96 94 91 89 86 86 80\r\n27 24 23 22 21 17 16\r\n50 49 45 43 42 39 38 39\r\n85 83 79 78 75 75\r\n19 16 12 10 9 8 4\r\n28 27 23 21 16\r\n91 88 83 80 77\r\n17 16 14 9 11\r\n74 71 66 64 64\r\n40 38 33 30 28 24\r\n66 64 63 56 53 46\r\n33 34 33 32 31 28 27\r\n52 54 52 50 47 46 43 46\r\n60 63 61 59 57 54 54\r\n82 84 82 81 78 77 74 70\r\n36 39 37 35 28\r\n67 69 66 64 67 65 64\r\n45 46 45 48 51\r\n83 84 82 83 81 80 80\r\n33 36 38 36 32\r\n88 91 88 87 89 86 80\r\n43 44 42 39 39 38 37\r\n35 36 36 33 30 31\r\n3 4 4 2 2\r\n77 79 76 74 74 71 67\r\n89 92 92 90 88 87 85 79\r\n45 48 44 41 40\r\n33 36 33 30 28 27 23 25\r\n66 69 68 65 61 59 57 57\r\n88 89 88 84 80\r\n46 47 43 42 36\r\n97 98 96 94 89 88 87 84\r\n11 14 12 5 3 6\r\n80 83 82 81 74 74\r\n24 26 23 16 12\r\n63 64 57 54 48\r\n86 86 85 83 82\r\n24 24 21 20 21\r\n56 56 53 52 51 51\r\n60 60 58 55 54 50\r\n93 93 90 87 86 83 78\r\n13 13 16 13 12 11 8 7\r\n64 64 63 66 64 66\r\n50 50 49 51 51\r\n34 34 33 32 35 31\r\n82 82 79 77 80 78 73\r\n47 47 47 46 43\r\n95 95 95 94 96\r\n48 48 48 45 44 44\r\n18 18 18 16 14 10\r\n87 87 85 84 84 83 81 75\r\n72 72 68 67 66 63\r\n65 65 64 61 57 55 52 54\r\n91 91 90 86 86\r\n46 46 42 39 35\r\n53 53 51 50 47 44 40 33\r\n85 85 78 76 75\r\n70 70 68 63 61 62\r\n47 47 44 38 35 33 31 31\r\n79 79 78 72 68\r\n73 73 68 65 58\r\n75 71 69 68 65\r\n52 48 46 43 40 38 35 37\r\n21 17 15 12 12\r\n41 37 35 32 28\r\n88 84 83 81 78 72\r\n68 64 61 63 61\r\n18 14 15 12 13\r\n62 58 56 53 54 51 51\r\n24 20 18 19 15\r\n93 89 87 89 84\r\n41 37 35 34 34 33 32\r\n44 40 39 36 36 34 35\r\n22 18 16 16 16\r\n86 82 80 77 77 74 73 69\r\n34 30 29 28 27 26 26 19\r\n93 89 87 83 80 79\r\n59 55 54 51 47 46 45 47\r\n20 16 13 12 8 6 4 4\r\n27 23 20 17 15 14 10 6\r\n25 21 17 16 11\r\n98 94 88 87 84\r\n65 61 58 55 52 47 44 46\r\n32 28 26 20 20\r\n82 78 77 74 72 67 63\r\n55 51 49 47 45 44 37 32\r\n36 31 28 27 26 23 21 20\r\n90 85 83 80 77 76 74 76\r\n15 10 8 7 6 5 3 3\r\n57 51 49 46 45 44 42 38\r\n29 24 21 20 19 13\r\n82 76 74 72 71 72 69 66\r\n10 4 7 4 5\r\n37 32 34 32 29 28 26 26\r\n56 50 52 50 46\r\n53 46 49 47 46 45 43 38\r\n76 71 68 68 65 64\r\n88 81 81 79 77 74 76\r\n83 76 76 73 73\r\n66 59 59 58 54\r\n98 93 92 90 90 84\r\n27 22 18 17 14 11\r\n29 24 20 19 17 15 18\r\n81 76 74 71 67 65 62 62\r\n69 63 60 56 55 51\r\n86 81 77 74 67\r\n74 67 62 59 58\r\n66 60 55 54 56\r\n53 46 39 37 35 33 33\r\n29 23 20 14 10\r\n33 28 27 26 19 16 15 8\r\n60 61 56 55 51\r\n97 91 88 87 86 80 81\r\n74 73 68 67 64 60\r\n23 21 17 15 12 12\r\n47 53 55 56 59 60 63 65\r\n38 38 38 36 34\r\n69 62 59 57 54\r\n13 13 12 9 8 7 7 9\r\n32 34 34 37 39 41 42 43\r\n81 77 75 74 75 73 72\r\n2 3 5 7 12 14 11\r\n43 43 41 40 40 39 33\r\n27 25 27 28 32\r\n47 51 53 55 62 63 69\r\n29 32 34 33 30 26\r\n51 58 60 61 65 68 68\r\n66 69 68 69 71 73 73\r\n84 84 86 83 79\r\n59 60 56 53 51\r\n15 20 22 23 27 29 32 39\r\n4 11 12 10 11 13\r\n39 35 33 31 33 31 31\r\n29 30 32 33 35 35\r\n84 83 84 84 87 88 91 96\r\n20 15 14 11 12\r\n16 16 14 15 14 13 11 12\r\n49 43 41 37 38\r\n9 16 20 22 25 28 32\r\n18 18 19 21 25 26\r\n72 74 75 78 82 82\r\n19 23 28 31 35\r\n86 79 78 74 70\r\n14 14 17 14 15 18 22\r\n59 52 51 54 51 48 46\r\n1 1 2 5 7 12 11\r\n54 50 49 47 43 43\r\n81 85 86 87 88 89 87 90\r\n7 8 11 13 16 22\r\n4 10 7 8 12\r\n70 64 63 60 62 62\r\n6 6 9 14 16 18 21 28\r\n56 61 58 60 62 67\r\n44 37 35 31 28 26 21\r\n14 18 20 23 27 27\r\n44 44 42 39 37 37 35 31\r\n95 95 97 99 97 99 96\r\n62 64 61 61 58 55\r\n52 58 58 59 60 61\r\n30 28 30 33 33 36\r\n51 47 44 41 40 37\r\n81 78 76 73 75 72\r\n23 24 28 30 33 35 38 40\r\n12 10 7 5 4 4 5\r\n16 19 19 22 26\r\n79 80 83 82 83 86 88\r\n76 69 66 65 62 62 61 62\r\n14 13 7 5 4 7\r\n56 50 48 45 45 41\r\n62 64 65 69 73\r\n64 68 71 72 75 74 74\r\n43 47 51 54 56 59 63\r\n60 56 53 51 50 47 46 42\r\n75 78 77 77 75 75\r\n53 53 57 60 61 66\r\n82 85 84 82 80 82 79 74\r\n66 61 58 51 49 47 46\r\n35 39 39 40 42 44 48\r\n42 35 34 31 28 21 20 20\r\n94 87 85 86 83 79\r\n53 55 56 59 62 66\r\n10 9 13 14 12\r\n19 25 27 29 32 39 39\r\n79 77 80 82 85 82 79\r\n39 35 33 34 33 30 26\r\n64 71 73 76 83 85 84\r\n64 65 63 66 70\r\n73 74 81 84 85 85\r\n34 34 35 36 36\r\n63 69 70 72 75 81 84 88\r\n66 70 77 79 82 85\r\n80 81 79 75 68\r\n91 87 86 85 82 80 83 86\r\n50 50 56 59 62\r\n2 7 7 10 14\r\n61 62 66 67 68 70 71 70\r\n43 43 45 47 47 48 48\r\n29 27 24 18 16 9\r\n17 21 23 23 29\r\n84 77 75 74 73 70 63\r\n32 30 29 26 22 21 16\r\n25 18 15 17 14 12 9 3\r\n82 85 88 90 92 90\r\n21 18 21 18 21\r\n76 82 82 83 85 87 87\r\n52 50 47 42 41\r\n22 26 28 29 30 30\r\n17 17 18 18 20 22\r\n26 26 22 20 14\r\n34 32 37 38 40 43 45 46\r\n60 60 62 65 62\r\n20 17 20 21 24 27 34 34\r\n41 40 41 42 43 47 50 50\r\n56 49 45 42 42\r\n21 21 25 26 29 30 32 36\r\n48 44 44 43 40 38\r\n94 93 91 93 92 88\r\n70 73 70 69 64 63\r\n42 46 47 50 54\r\n25 26 24 22 19 17 19\r\n95 95 94 92 90 93 90 88\r\n23 22 24 23 27\r\n75 76 75 72 71 68\r\n74 73 71 70 69 66 59 59\r\n14 20 22 24 26 29 27\r\n15 18 22 23 24 29\r\n50 50 51 54 56 57 59\r\n41 39 39 41 43 44 47 51\r\n22 22 19 19 18 18\r\n63 63 66 68 69 70 74\r\n21 20 19 18 16 13 12 5\r\n72 69 66 66 65 61\r\n61 68 69 71 74 75 75\r\n81 75 74 73 72 66 60\r\n18 18 19 19 20 22 19\r\n78 74 72 69 65 64 61 62\r\n30 26 24 21 19 19 19\r\n76 76 78 79 80 78 78\r\n32 38 40 43 50\r\n63 56 56 54 54\r\n81 82 81 79 79 81\r\n85 85 86 86 87 88 94\r\n65 61 59 56 49\r\n1 5 8 10 8 10 9\r\n63 64 67 67 68 69 67\r\n44 44 45 49 49\r\n87 83 82 79 82\r\n54 59 60 63 64 67 70 74\r\n13 12 11 9 8 8\r\n30 32 31 30 24 21 16\r\n77 75 72 71 73 70 67 67\r\n86 86 91 93 93\r\n70 70 67 62 60 59 58\r\n44 50 51 57 59 60 62\r\n84 84 90 91 95\r\n42 46 47 50 53 58 58\r\n31 27 25 25 28\r\n1 1 4 1 1\r\n47 52 52 54 57 64\r\n38 36 38 37 37\r\n49 49 45 43 42 41\r\n20 19 26 28 33\r\n50 53 55 54 56 63\r\n19 26 30 33 35 34\r\n73 73 76 79 82 82 86\r\n40 36 33 32 35 29\r\n50 51 53 54 60 67\r\n68 72 74 77 79 81 81 84\r\n76 79 82 84 91 94 98\r\n8 6 7 9 11 11\r\n56 50 48 48 46\r\n14 17 14 14 10\r\n9 13 18 19 17\r\n57 58 55 55 52 50 49 43\r\n85 82 80 77 74 71 68\r\n80 81 82 84 86 88\r\n17 19 20 21 23 24 25\r\n85 83 81 80 78\r\n50 47 46 44 42\r\n71 69 66 65 63 62\r\n80 78 75 73 70\r\n28 29 32 33 34 36\r\n36 33 30 28 25 22 20\r\n66 68 70 71 74 75\r\n36 33 32 30 29 27 26 23\r\n67 66 64 62 61 59 58 55\r\n45 43 40 39 36 34 31 30\r\n25 23 20 19 16 15 14\r\n67 65 63 60 59 58\r\n3 6 9 10 12 15 17 20\r\n45 42 40 38 37 34\r\n67 69 72 74 77 80 81 84\r\n86 84 82 80 77\r\n13 11 10 7 6 4 2\r\n18 20 21 23 26 28 31\r\n79 80 83 85 88 89 92 95\r\n70 72 74 76 77 78 81 82\r\n43 45 48 51 52\r\n66 63 62 61 60 57 55\r\n15 12 11 8 5\r\n86 83 82 81 78\r\n75 78 81 82 85\r\n28 29 32 33 36 38\r\n72 75 78 80 81 83 86 88\r\n23 21 18 16 14\r\n98 96 94 93 90\r\n76 75 74 71 69 68 65 62\r\n66 65 64 61 60 57 54 53\r\n73 71 70 67 66 65 62 59\r\n41 44 45 48 50 53\r\n27 24 23 22 19\r\n17 14 13 12 10 9 6 5\r\n36 33 30 28 26 24 21\r\n94 92 89 88 85\r\n50 53 55 57 60 61\r\n62 65 66 69 70 73\r\n47 46 44 41 38 35 34 31\r\n48 51 53 54 55 56 59\r\n78 79 80 81 82 85 87 89\r\n51 54 56 58 61 64 65\r\n50 52 53 54 55 58 61 62\r\n76 75 74 71 69 66 64\r\n61 64 67 69 70 72 73\r\n75 74 72 71 70 67\r\n38 39 41 42 43 45 46\r\n76 79 81 84 85 86 89 91\r\n59 58 57 56 55 54 51 50\r\n88 85 84 82 81 80 79 76\r\n15 12 9 8 7 4 1\r\n37 36 34 33 31 30 29\r\n66 69 72 74 77 78 79 81\r\n54 51 49 46 44\r\n65 63 60 59 58\r\n31 33 34 36 39 40\r\n7 10 11 13 15 18 21\r\n17 19 21 23 24 27 29 30\r\n33 30 27 24 23 22 20 18\r\n47 46 45 44 42 39 36 35\r\n45 42 40 38 37\r\n31 33 34 37 40 41 42 44\r\n95 93 90 89 86 84 82\r\n53 50 49 47 45 43 41 39\r\n38 37 34 31 30 27 26\r\n48 50 52 53 54\r\n9 10 12 13 16 17 18 19\r\n75 77 80 83 85\r\n39 40 43 45 48 49\r\n89 90 92 94 95 98 99\r\n78 77 76 74 73 71\r\n32 35 36 38 39 42\r\n95 94 93 90 89 86 83 82\r\n63 62 59 57 54 52 49 46\r\n45 46 47 49 52 54\r\n86 85 84 83 80 77\r\n61 58 56 54 53\r\n42 40 38 35 32 30\r\n86 87 90 91 93 94 96 99\r\n45 48 51 53 56\r\n49 50 51 53 55 57\r\n16 15 13 10 8 7 6\r\n37 40 41 43 46\r\n83 82 79 76 75\r\n9 12 15 18 20\r\n31 30 29 27 24 22\r\n30 33 35 37 39 41 43\r\n25 22 20 19 16 15 13 12\r\n53 51 48 45 42 39 37\r\n30 29 27 26 25 23 20 18\r\n36 38 41 42 43 44 46 49\r\n22 21 18 15 14 11 9\r\n46 47 48 51 54\r\n39 41 44 45 47 49 51\r\n52 50 48 45 42 41\r\n38 39 42 45 48 50 53 56\r\n50 51 53 56 58 59\r\n86 85 83 80 78 76 75 73\r\n59 58 57 54 51\r\n22 24 25 27 29 30 32 35\r\n11 13 15 16 19 21\r\n36 33 31 29 28 27 25 22\r\n43 42 39 37 35 33 31 30\r\n69 67 66 64 61\r\n80 77 75 72 70 68 67\r\n55 57 60 63 66 68\r\n80 77 76 73 72\r\n19 17 15 14 13\r\n50 48 45 44 42\r\n6 7 10 13 14\r\n50 52 55 57 60\r\n67 64 62 60 59 56 54 52\r\n25 28 30 32 35\r\n80 77 76 73 72 70 69\r\n36 35 32 29 28 27 26 25\r\n64 62 61 60 57 54\r\n76 78 79 81 84 87 90 91\r\n69 71 72 75 78\r\n22 19 16 15 13 12 11\r\n95 92 91 88 86 84 81\r\n76 79 80 82 83 86 88 89\r\n25 26 28 29 30 32\r\n4 7 10 12 15\r\n70 71 74 77 78 81\r\n27 29 32 35 38 41 44 46\r\n73 72 69 66 64\r\n17 14 13 10 7 5\r\n47 44 42 40 37 36\r\n28 30 32 33 34 37 39 41\r\n86 88 89 90 93\r\n79 78 76 74 71\r\n44 46 47 48 51 53 54\r\n82 84 87 88 91 92 95 96\r\n24 22 21 18 16 14\r\n48 47 46 45 42\r\n73 76 77 80 81\r\n29 28 27 26 24\r\n59 56 54 52 49 47\r\n43 45 46 49 51 53 56 59\r\n25 24 23 21 18 16 13 12\r\n60 59 57 54 52 50\r\n23 20 18 15 14 12\r\n53 55 56 58 59 60\r\n86 89 92 94 96\r\n21 20 18 16 14 11\r\n61 63 66 68 70 71 73\r\n49 46 45 42 40 38 37\r\n9 11 14 16 19 20\r\n41 39 36 33 30 28 25 23\r\n52 54 55 56 57 58 59 62\r\n20 18 15 13 11 10\r\n62 60 57 56 53 52 50 49\r\n69 72 75 77 79 81\r\n80 81 84 87 90 92 93\r\n34 32 31 28 26 24 22\r\n21 20 18 15 14 11 9 6\r\n89 87 86 83 80 79 77 74\r\n29 32 33 34 35 37 38\r\n29 27 26 24 21 18\r\n38 41 42 45 46 49 50\r\n63 64 67 69 71 73 74\r\n40 42 45 48 49\r\n17 18 19 21 22 23\r\n5 6 9 10 13 15 17\r\n44 47 50 52 55 58 60 62\r\n28 25 24 21 18 16 15\r\n39 38 36 35 34 33 31\r\n78 76 75 74 73 70\r\n69 68 65 64 63\r\n80 82 83 85 88 91 94 96\r\n76 74 71 70 69 68\r\n81 84 86 88 89\r\n40 42 44 45 46 48 51 53\r\n50 51 52 54 55 57\r\n57 60 62 63 65 67 70\r\n46 45 42 39 37 36\r\n72 71 70 68 66\r\n37 40 42 45 47\r\n53 56 58 59 62\r\n87 85 84 82 79 77 75 72\r\n82 81 80 77 74 71 70\r\n28 30 31 32 33\r\n37 36 33 30 27 26 24 22\r\n60 59 58 56 54\r\n86 85 83 80 78 75 72 71\r\n20 21 22 25 27\r\n39 41 43 44 47 48 49 50\r\n33 32 29 27 26 23 20 18\r\n40 37 36 33 31 30\r\n23 25 28 30 32 35\r\n82 81 79 76 75 73 71 68\r\n79 77 76 75 73 72 70 69\r\n82 85 86 89 91 94 97\r\n87 88 90 91 93\r\n14 17 19 20 22 25 26 27\r\n82 79 76 75 72 70 68\r\n88 87 84 81 79 77\r\n15 13 12 10 9 8 7\r\n1 2 5 6 9 11\r\n20 18 15 14 12 11 9 6\r\n11 9 6 3 1\r\n66 65 63 60 57 54\r\n64 63 62 61 58 57\r\n79 77 75 74 72\r\n62 60 59 58 57 54 53\r\n17 16 13 10 8\r\n59 62 64 65 68 69\r\n82 80 79 77 74 72\r\n16 13 11 8 7 4\r\n17 14 12 9 7 4\r\n46 45 43 40 39 36 33\r\n85 86 87 89 92 94 96 99\r\n50 52 55 57 60 62\r\n64 65 67 68 70 73 76 79\r\n54 53 51 49 47 44 42 39\r\n29 30 31 34 35 36 38\r\n40 37 34 33 31 30 27 24\r\n68 70 71 74 76 77 78\r\n62 61 59 58 57 56 55 52\r\n4 5 8 9 12 13\r\n89 86 85 82 80 79\r\n5 8 9 10 13 14 17\r\n84 82 81 78 76 73 71\r\n84 86 87 90 93 96 97\r\n32 31 29 28 26 23\r\n17 19 21 23 26 29 31\r\n62 65 66 67 69 72\r\n43 45 47 48 50 52 55\r\n36 35 34 33 31 29 27\r\n18 15 14 13 11\r\n36 35 32 30 27\r\n13 16 17 19 20 21 23\r\n98 97 95 93 90 87 86\r\n95 93 91 90 88 85 82\r\n28 26 24 21 19 18 16 13\r\n61 58 57 54 53 51 49 47\r\n81 84 86 88 90 92 93\r\n45 46 49 50 51\r\n48 51 53 54 56 57 58 60\r\n73 70 69 68 66 64\r\n75 72 70 67 65 64 62\r\n50 48 45 42 41 38 37 36\r\n44 42 39 37 34 32\r\n46 45 44 42 40\r\n51 48 46 44 41 39 37\r\n19 18 16 15 12 11\r\n39 40 42 45 46\r\n76 77 78 81 82 83 86 87\r\n90 89 88 85 83 82 81 79\r\n72 74 76 78 79 80\r\n65 66 67 68 70 72\r\n49 51 54 56 59 62 63\r\n37 35 32 30 28 25 24 22\r\n90 87 86 84 82\r\n61 64 65 67 68 71 74 77\r\n1 3 4 7 10\r\n61 60 59 58 57 55 54 52\r\n6 8 9 11 13 14 17 19\r\n56 57 58 59 61 63\r\n58 60 63 66 67\r\n22 20 17 16 15 14 13 10\r\n66 63 62 60 57 56 55 53\r\n61 64 67 70 71 74 77\r\n88 86 84 82 80 78 77 75\r\n6 9 11 14 16\r\n75 76 79 82 83 85 86\r\n78 79 80 81 84 85\r\n14 11 8 5 2 1\r\n24 27 30 31 32 35\r\n85 84 83 80 77\r\n68 71 74 76 79 81 82 85\r\n21 19 17 16 14 11 9\r\n93 92 90 87 85\r\n80 78 76 75 72 69\r\n84 87 88 90 93 94 97\r\n54 53 50 49 48 45\r\n41 42 44 45 47\r\n24 26 29 32 35 38 39 41\r\n54 52 49 47 44 42 41 40\r\n39 42 43 44 45 48 50\r\n82 81 79 76 73 71\r\n70 67 65 64 63 61\r\n57 56 53 51 49 46\r\n74 76 79 81 83 85 87 90\r\n56 59 61 64 67 70 71\r\n31 29 28 27 24 23\r\n59 57 55 52 50\r\n82 85 88 91 94 95 97\r\n60 58 55 53 51\r\n57 58 60 63 65 68\r\n41 44 46 48 50 51 53\r\n44 46 47 50 53\r\n33 34 36 38 41 42 44\r\n18 20 22 23 26 28 29\r\n51 48 47 45 44 42\r\n23 21 19 17 14 12\r\n58 56 53 52 49 47 46 44\r\n98 96 95 94 91\r\n80 78 76 75 73\r\n58 61 63 64 66\r\n83 85 87 88 89\r\n23 21 19 17 15 14 12 9\r\n60 62 63 64 65 68\r\n42 41 38 37 36 33\r\n93 92 90 88 87 86 84 82\r\n31 32 34 36 39 42\r\n8 10 12 13 16 17 18 19\r\n14 17 18 20 23 24\r\n8 11 13 14 17 18 21\r\n69 68 66 63 61 58 55\r\n90 87 85 82 80 79\r\n38 35 32 30 28\r\n18 20 23 26 28 29 30\r\n17 16 13 10 8 7 5\r\n83 82 80 77 75 72 69 66\r\n87 88 89 92 94\r\n69 71 72 74 76 78 81 82\r\n49 46 43 40 37 34 33\r\n30 28 26 24 23 20\r\n44 43 40 39 37 34 33 31\r\n21 23 26 29 32 33 34 36\r\n61 59 58 56 54 52 50 48\r\n53 50 49 48 45 42\r\n63 66 68 71 73 76\r\n57 55 53 50 49\r\n54 57 60 62 65\r\n21 22 25 27 29 30\r\n12 14 15 18 20 21 22 23\r\n68 71 73 74 76 77 80\r\n15 13 12 9 6 5 2\r\n35 37 40 41 42 45 46\r\n56 55 53 52 50\r\n38 39 42 43 44\r\n48 46 45 43 42\r\n95 92 91 88 86 84 83 80\r\n48 51 52 55 58\r\n40 42 44 46 49 51";

    List<List<int>> ConvertToListOfLists(string input)
    {
        var lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var listOfLists = new List<List<int>>();

        foreach (var line in lines)
        {
            var integers = new List<int>();
            var numbers = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numbers)
            {
                if (int.TryParse(number.Trim(), out int n))
                {
                    integers.Add(n);
                }
            }
            listOfLists.Add(integers);
        }
        return listOfLists;
    }

    // END INPUT

    // Solutions

    // Part 1
    int TotalNumberOfSafeReports(List<List<int>> l, int acc = 0)
        => l switch
        {
        [] => acc,
        [var x, .. var xs] => TotalNumberOfSafeReports(xs, IsReportSafe([.. x]) ? acc + 1 : acc)
        };

    bool IsReportSafe(Span<int> l, bool isDecreasing = false, bool isIncreasing = false)
    {
        if (isIncreasing && isDecreasing) return false;

        return l switch
        {
        [] => true,
        [var x, var y] when IsDiffToHigh(x, y) => false,
        [var x, var y, .. var xs] when IsDiffToHigh(x, y) => false,
        [var x, var y, .. var xs] when x > y => IsReportSafe([y, .. xs], true, isIncreasing),
        [var x, var y, .. var xs] when x < y => IsReportSafe([y, .. xs], isDecreasing, true),
        [var x, .. var xs] => IsReportSafe(xs),
        };
    }

    bool IsDiffToHigh(int x, int y) => x - y > 3 || x - y < -3 || x - y == 0;

    //List<List<int>> reports1 = ConvertToListOfLists(input);
    //Console.WriteLine($"Total safe: {TotalNumberOfSafeReports(reports1)}");

    // Part 2

    int TotalNumberOfSafeReportsDamp(List<List<int>> l, int acc = 0, Dictionary<int[], bool>? memo = null)
    {
        if (l.Count == 0) return acc;  // base

        memo ??= new Dictionary<int[], bool>();

        (bool isSafe, var dic) = IsReportSafeWithDampener([.. l[0]], memo);

        return l switch
        {
        [_, .. var xs] => TotalNumberOfSafeReportsDamp(xs, isSafe ? acc + 1 : acc, dic)
        };
    }

    // Need to check all combinations which is hard with pattern matching :(
    (bool, Dictionary<int[], bool>) IsReportSafeWithDampener(Span<int> l, Dictionary<int[], bool> memo)
    {

        for (global::System.Int32 i = 0; i < l.Length; i++)
        {
            var preSlice = l[..i];
            var postSlice = l[(i + 1)..];
            Span<int> subset = [.. preSlice, .. postSlice];

            if (memo.ContainsKey(subset.ToArray())) return (true, memo);

            bool safe = IsReportSafe(subset);
            if (safe)
            {
                memo.Add(subset.ToArray(), true);
                return (true, memo); // just need one safe combination
            }
        }
        return (false, memo);
    }

    //List<List<int>> reports1 = ConvertToListOfLists(input);
    //Console.WriteLine($"Total safe: {TotalNumberOfSafeReportsDamp(reports1)}");

}