``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19042.2006/20H2/October2020Update)
Intel Core i9-10885H CPU 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |           Mean |       Error |        StdDev |         Median | Rank |   Gen0 |   Gen1 | Allocated |
|------- |---------------:|------------:|--------------:|---------------:|-----:|-------:|-------:|----------:|
|    SOA |      0.0665 ns |   0.0286 ns |     0.0839 ns |      0.0185 ns |    1 |      - |      - |         - |
|   Oist |      4.7678 ns |   0.1163 ns |     0.2576 ns |      4.6868 ns |    2 | 0.0029 |      - |      24 B |
|   gali |    324.3612 ns |   6.6456 ns |    19.3856 ns |    325.1679 ns |    3 | 0.0029 |      - |      24 B |
|   tgje |    524.9791 ns |  22.4510 ns |    66.1973 ns |    492.8855 ns |    4 | 0.0029 |      - |      24 B |
|   jaei |  7,838.0468 ns | 261.5956 ns |   737.8349 ns |  7,522.0230 ns |    5 |      - |      - |     120 B |
|   Olkv | 10,195.6227 ns | 412.7188 ns | 1,197.3719 ns | 10,229.3568 ns |    6 | 3.3112 | 0.2365 |   27736 B |
