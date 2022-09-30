if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    
def find_percentage(name):
        return f"{sum(student_marks[name]) / len(student_marks[name]):.2f}"

print(find_percentage(query_name))
