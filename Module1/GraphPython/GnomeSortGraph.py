import pandas as pd
import matplotlib.pyplot as plt

data = pd.read_csv("../Day1/timings.csv")

plt.figure(figsize=(8, 5))
plt.plot(data["Size"], data["Ticks"], marker='o', linestyle='-', color='blue', label='GnomeSort')
plt.title("Час виконання GnomeSort в залежності від розміру масиву")
plt.xlabel("Кількість елементів")
plt.ylabel("Час виконання (Ticks)")
plt.grid(True)
plt.legend()
plt.tight_layout()
plt.savefig("gnomesort_timing_plot.png")
plt.show()