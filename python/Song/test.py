# -*- coding: utf-8 -*-
# @Time : 29/06/2022 6:15 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
class Song:
    def __init__(self, name):
        self.name = name
        self.next = None

    def next_song(self, song):
        self.next = song

    def is_repeating_playlist(self):
        """
        :returns: (bool) True if the playlist is repeating, False if not.
        """
        songs = set()
        next_song = self
        while next_song:
            if next_song.name in songs:
                return True
            else:
                songs.add(next_song.name)
                next_song = next_song.next or None
        return False


first = Song("Hello")
second = Song("Eye of the tiger")

first.next_song(second)
second.next_song(first)

print(first.is_repeating_playlist())