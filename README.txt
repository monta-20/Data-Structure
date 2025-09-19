🔹 What is a Graph?

A graph is a data structure that consists of:

Vertices (nodes): the entities in the graph

Edges (links): connections between the vertices

Formally:

G = (V, E)
V = set of vertices
E = set of edges


Edges can be directed or undirected, and they may have weights or not.

🔹 Types of Graphs

Directed Graph (Digraph)

Edges have a direction: A → B

Example: Twitter followers (A follows B, not necessarily vice versa)

Undirected Graph

Edges have no direction: A — B

Example: Facebook friends (friendship is mutual)

Weighted Graph

Each edge has a weight (cost, distance, time)

Example: Road networks (distance between cities)

Unweighted Graph

Edges have no weight, just a connection

Cyclic Graph

Contains at least one cycle (a path that starts and ends at the same vertex)

Acyclic Graph

No cycles

Example: Trees

Connected Graph (for undirected graphs)

Every vertex can be reached from any other vertex

Strongly Connected Graph (for directed graphs)

There is a path from every vertex to every other vertex

Bipartite Graph

Vertices can be split into two disjoint sets

No edge connects vertices of the same set

🔹 Properties of a Graph

Number of vertices (|V|) – the total count of nodes

Number of edges (|E|) – the total count of connections

Degree of a vertex

For undirected graphs: number of edges connected to it

For directed graphs:

In-degree: number of incoming edges

Out-degree: number of outgoing edges

Path – a sequence of vertices connected by edges

Cycle – a path that starts and ends at the same vertex

Connectedness – whether all vertices are reachable

Weighted / Unweighted – whether edges have costs

Directed / Undirected – whether edges have a direction

🔹 Representations of a Graph

Adjacency List

For each vertex, maintain a list of its neighbors

Memory-efficient for sparse graphs

Adjacency Matrix

2D array n x n

matrix[i][j] = 1 if there is an edge between i and j, otherwise 0

Faster to check if an edge exists

🔹 Applications of Graphs

Social networks (friends, followers)

Road maps and GPS routing

Search engines (PageRank algorithm)

Scheduling and dependency management

AI (game maps, pathfinding)

For more info : https://www.datacamp.com/tutorial/introduction-to-graph-theory