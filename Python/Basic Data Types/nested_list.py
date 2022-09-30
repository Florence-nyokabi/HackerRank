if __name__ == '__main__':
    students = []
    for _ in range(int(input())):
        name = input()
        score = float(input())
        students.append([name, score])
    mn = min(students, key=lambda x: x[1])
    nonlowest = sorted([student for student in students if student[1] > mn[1]], key= lambda x: x[1])
    seconds = sorted([student[0] for student in nonlowest if student[1] == nonlowest[0][1]])
    for student in seconds:
        print(student)
