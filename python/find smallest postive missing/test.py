def findMissingNo(lst):
    lst.append(0)
    n = len(lst)
    for i in range(n):
        if lst[i] < 0 or lst[i]>n:
            lst[i] = 0
    for i in range(n):
        lst[lst[i]%n]+=n
    for i in range(1,n):
        if lst[i]/n ==0:
            return i
        
    return n

if __name__ == "__main__":
    lst = [1,3,5,4,-3,-1]
    print(findMissingNo(lst))
    lst = [3,4,-1,1]
    print(findMissingNo(lst))
    lst = [1,2,0]
    print(findMissingNo(lst))