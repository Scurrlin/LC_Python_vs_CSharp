import pandas as pd
import matplotlib.pyplot as plt

file_path = 'Python&C#_raw_data.xlsx'
excel_data = pd.ExcelFile(file_path)

runtime_data = pd.read_excel(
    excel_data,
    sheet_name='Runtime',
    header=None
)

memory_data = pd.read_excel(
    excel_data,
    sheet_name='Memory',
    header=None
)

def create_bar_graph(x, y1, y2, labels, title, y_label, filename, note, y_ticks, include_note):
    fig = plt.figure(figsize=(14, 8), facecolor='black')
    ax = fig.add_subplot(111)
    ax.set_facecolor('black')
    
    bar_width = 0.35
    index = range(len(x))
    
    ax.bar(index, y1, bar_width, label='Python', color='#FFD43B')
    ax.bar([i + bar_width for i in index], y2, bar_width, label='C#', color='#7355dd')

    ax.set_xlabel(labels['x_label'], color='white')
    ax.set_ylabel(y_label, color='white')
    ax.set_title(title, color='white')
    ax.set_xticks([i + bar_width / 2 for i in index], x, rotation=45, ha="right")
    ax.set_yticks(y_ticks)
    ax.tick_params(colors='white')
    ax.legend(loc='upper right', facecolor='black', edgecolor='white', labelcolor='white')
    
    ax.grid(axis='both', linestyle='--', linewidth=0.5, color='#C8C8C8', alpha=0.45)
    for spine in ax.spines.values():
        spine.set_color('white')

    fig.tight_layout(rect=[0, 0.05, 1, 1])
    if include_note:
        fig.text(0.5, 0.01, note, wrap=True, horizontalalignment='center', fontsize=8, color='white')
    
    fig.savefig(filename, facecolor=fig.get_facecolor())
    plt.close(fig)

problems = [39, 46, 78, '53*', 169, '240*', 70, 198, '300*', '200*', 733, 994, '55*', 406, '452*', 33, 374, 704, 3, 438, 567, 56, 57, '912A*', '912B*', 94, 144, 230, '11*', '15*', '344*']
python_runtime_values = [runtime_data.iat[i, 5] for i in range(3, 64, 2)]
cs_runtime_values = [runtime_data.iat[i, 5] for i in range(4, 65, 2)]

create_bar_graph(problems, python_runtime_values, cs_runtime_values, 
                 {'x_label': 'LeetCode Problem #'}, 
                 'Average Runtime (ms) by LeetCode Problem #', 
                 'Average Runtime (ms)', 
                 'avg_runtime_by_lc_problem.png', 
                 '*Runtime reduced by a factor of 10 to not skew data visualization',
                 [0, 25, 50, 75, 100, 125, 150, 175],
                 include_note=True)

algorithms = ['Backtracking', 'Divide & Conquer', 'Dynamic Programming', 'Graphs', 'Greedy', 'Searching', 'Sliding Window', 'Sorting', 'Trees', 'Two Pointers']
python_algo_runtime = [runtime_data.iat[i, 4] for i in [3, 9, 15, 21, 27, 33, 39, 45, 53, 59]]
cs_algo_runtime = [runtime_data.iat[i, 4] for i in [4, 10, 16, 22, 28, 34, 40, 46, 54, 60]]

create_bar_graph(algorithms, python_algo_runtime, cs_algo_runtime, 
                 {'x_label': 'Algorithm'}, 
                 'Average Runtime (ms) by Algorithm', 
                 'Average Runtime (ms)', 
                 'avg_runtime_by_algorithm.png', 
                 '',
                 [0, 20, 40, 60, 80, 100, 120],
                 include_note=False)

memory_problems = [39, 46, 78, 53, 169, 240, 70, 198, 300, 200, 733, 994, 55, 406, 452, 33, 374, 704, 3, 438, 567, 56, 57, '912A*', '912B', 94, 144, 230, 11, 15, '344*']
python_memory_values = [memory_data.iat[i, 5] for i in range(3, 64, 2)]
cs_memory_values = [memory_data.iat[i, 5] for i in range(4, 65, 2)]

create_bar_graph(memory_problems, python_memory_values, cs_memory_values, 
                 {'x_label': 'LeetCode Problem #'}, 
                 'Average Memory (MB) by LeetCode Problem #', 
                 'Average Memory (MB)', 
                 'avg_memory_by_lc_problem.png', 
                 '*Memory reduced by a factor of 10 to not skew data visualization',
                 [0, 20, 40, 60, 80],
                 include_note=True)

memory_algo_python = [memory_data.iat[i, 4] for i in [3, 9, 15, 21, 27, 33, 39, 45, 53, 59]]
memory_algo_cs = [memory_data.iat[i, 4] for i in [4, 10, 16, 22, 28, 34, 40, 46, 54, 60]]

create_bar_graph(algorithms, memory_algo_python, memory_algo_cs, 
                 {'x_label': 'Algorithm'}, 
                 'Average Memory (MB) by Algorithm', 
                 'Average Memory (MB)', 
                 'avg_memory_by_algorithm.png', 
                 '',
                 [0, 10, 20, 30, 40, 50],
                 include_note=False)

print("Visualizations have been generated and saved successfully.")