
def testing():
    yield 1
    yield 2

t = testing()

for i in range(5):
    print(next(t))

